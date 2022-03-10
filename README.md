# Windows Forms Sample App

This is a sample application using Windows Forms and .NET 6.0 showcasing
multiple modern techniques, such as dependency injection and view-based
navigation.

It is a simple task list application using a mock database in-memory, using
two views: a task list view and a task creation/update view.

Views serve as a basis for injectable UI, as Windows Forms doesn't natively
play well with DI/IoC. This is handled by `ViewService`, which resolves
dependencies using utilities from `Microsoft.Extensions.DependencyInjection`.

One key point about constructor dependencies in Windows Forms is that the
Visual Studio form/user control designer is unable to edit classes with no
empty constructor. A simple workaround for this is to make a private empty
constructor, as it uses reflection to instantiate any constructor regardless of
accessibility. Nullable member checks can be safely ignored due to the designer
not making any use of them (it only really executes `InitializeComponent()`).

Other than that there is a single form used as a host for said views.

A few improvements could be done, namely some kind of message box service
(instead of using the static `MessageBox` class) as well as caching views/data,
the latter of which is probably handled best by a proper database/cache
framework rather than a basic mockup service.
