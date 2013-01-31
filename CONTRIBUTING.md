# Contributing to V1TaskManager

 1. [Getting Involved](#getting-involved)
 2. [Reporting Bugs](#reporting-bugs)
 3. [Contributing Code](#contributing-code)

## Getting Involved

We need your help to make the V1TaskManager a useful tool for estimating with VersionOne. While third-party patches are absolutely essential, they are not the only way to get involved. You can help the project by discovering and [reporting bugs](#reporting-bugs) and helping others on the [versionone-dev group](http://groups.google.com/group/versionone-dev/) and [GitHub issues](https://github.com/versionone/V1TaskManager/issues).

## Reporting Bugs

Before reporting a bug on the project's [issues page](https://github.com/versionone/V1TaskManager/issues), first search the already reported issues for similar cases, and if it has been reported already, just add any additional details in the comments. After you made sure that you have found a new bug, here are some tips for creating a helpful report that will make fixing it much easier and quicker:

 * Write a **descriptive, specific title**. Bad: *Problem with installer*. Good: *Installing on 64-bit Windows 8 fails*.
 * Whenever possible, include **Class and Method** info in the description.
 * Create a **simple test case** that demonstrates the bug (e.g. using [NUnit](http://www.nunit.org/)).

## Contributing Code

### Building from Source
The solution uses NuGet to resolve external dependencies. Use Visual Studio or 
MS Build to create the EXE.

### Considerations for Accepting Patches

Before sending a pull request with a new feature, first check if it has been discussed before already (either on [GitHub issues](https://github.com/versionone/V1TaskManager/issues) or [versionone-dev group](http://groups.google.com/group/versionone-dev/)).

### Making Changes to V1TaskManager Source

If you are not yet familiar with the way GitHub works (forking, pull requests, etc.), be sure to check out the awesome [article about forking](https://help.github.com/articles/fork-a-repo) on the GitHub Help website - it will get you started quickly.

You should always write each batch of changes (feature, bugfix, etc.) in **its own topic branch**. Please do not commit to the `master` branch, or your unrelated changes will go into the same pull request.

You should also follow the code style and whitespace conventions of the original codebase.

### Open Source Licenses and Attribution

Regardless of whether attribution is required by a dependency, we want to acknowledge the work that we depend up on and make it easy for people to evaluate the legal implications of using this project. Therefore, we require all dependencies be attributed in the ACKNOWLEDGEMENTS.md. This should include the persons or organizations who contributed the libraries, a link to the source code, and a link to the underlying license (even when this project sub-licenses under the modified BSD license).
