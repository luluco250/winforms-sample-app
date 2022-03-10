# Windows Forms Sample App

This is a sample application using Windows Forms and .NET 6.0 showcasing
multiple modern techniques, such as dependency injection and view-based
navigation.

It is a simple task list application using a mock database in-memory, using
two views: a task list view and a task creation/update view.

Views serve as a basis for injectable UI, as Windows Forms doesn't natively
play well with DI/IoC. This is handled by `ViewService`, which resolves
dependencies using utilities from `Microsoft.Extensions.DependencyInjection`.

Other than that there is a single form used as a host for said views.

A few improvements could be done, namely some kind of message box service
(instead of using the static `MessageBox` class) as well as caching views/data,
the latter of which is probably handled best by a proper database/cache
framework rather than a basic mockup service.
