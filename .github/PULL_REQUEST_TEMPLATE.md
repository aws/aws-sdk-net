<!--- Provide a general summary of your changes in the Title above -->

## Description
<!--- Describe your changes in detail -->

<!--

For S3 generation PRS uncomment the below lines
## How to review S3 Generation PRs

For reviewing S3 generation PRs it is best to review each file outside of the GitHub diff UI. When comparing
the custom code to the generated code it is best to have the custom code file open in GitHub, then open
the generated file by clicking the three dots on the top of the file and clicking "view file". Then have the
custom code on the left and generated code on the right to make sure the change looks good. You should look for behavioral changes such as missing custom logic from getters & setters, or differences in marshalling and unmarshalling behavior as a result of missing custom logic.

Custom logic that exists in the custom code may have been moved to a custom method such as PostMarshallCustomization()
which exists in a custom version of the marshaller, or in the case of unmarshallers, a specific partial method may have 
been added to preserve partial logic. Make sure to view those as well.

[This](https://github.com/aws/aws-sdk-net/blob/main/sdk/src/Services/S3/Custom/Model/Internal/MarshallTransformations/ListObjectsV2ResponseUnmarshaller.cs#L32-L43) is a good example of a custom method that is declared in the custom unmarshaller that is used by the generated unmarshaller.

Copy and paste the below prompt into Q to have Q browser extension catch any possible mistakes as well.
-->

<!--
Here is a prompt you can use in Q browser extension to also have it look at the PR in case we run out of free GitHub copilot PR reviews

You are an expert C# software engineer that is an expert at finding breaking changes in PRs. You are working on the AWS SDK for .NET to change S3 service changes from manual to automatically generated using the generator.
This upgrade is being done in phases where a certain number of operations are changed from manual to automatically generated.
S3 MUST work exactly like it did before and we must not cause breaking changes. Some things that would cause breaking changes are:


1. logical conditions that existed in the older code that have changed or removed.
2. getter and setter code have changed, disregarding private variable name changes such as _type and type.
3. properties that were set to values that are no longer set.
4. changes in the response output.


When comparing marshallers, some logic was moved to PostMarshallCustomization. In that case the marshaller is split between a generated marshaller 
and the custom marshaller which implements PostMarshallCustomization. Make sure to check PostMarshallCustomization 
for any backwards compatible issues there as well.


For unmarshallers, some logic may have been moved to custom methods in the custom class for the unmarshaller.
Check to make sure those don't contain any backwards incompatible changes as well.

Typically the changes being made by the team involve moving code from the `sdk/src/Services/S3/Custom/` folder to the `sdk/src/Services/S3/Generated/` folder
as generator changes are introduced to automatically generate the S3 service. When possible, match for the comparison where the filename is the same between the custom and generated folders. Example:

* `sdk/src/Services/S3/Custom/Model/InitiateMultipartUploadRequest.cs` is the custom file
* `sdk/src/Services/S3/Generated/Model/InitiateMultipartUploadRequest.cs` is the generated file the code is moved to.

Analyze this PR in extreme detail to determine if any breaking changes are being introduced and list each breaking change. 
I do not want recommendations. I want actual defective code that has been lost from the manual to automatic generated changes.

* If you do not finish all the files I will ask you to continue processing the files.
* Retain all of this context while working. If you lose this context ask me to reload it for you.
* If you are unsure about anything ask me to clarify or help. Code can be confusing or tricky.
* Do NOT make mistakes. Customers are depending on your perfect breaking change finding abilities.
* DO NOT ERROR 

For output, list each file that has an issue. If there is an ISSUE response list the exact issues in a list format. 
At the end list how many files you analyzed out of the total. 
If this number is less than the total number of "Files changed" in the PR continue looking at the remainder of the unchecked files.


-->



## Motivation and Context
<!--- Why is this change required? What problem does it solve? -->
<!--- If it fixes an open [issue][issues], please link to the issue here -->

## Testing
<!--- Please describe in detail how you tested your changes -->
<!--- Include details of your testing environment, and the tests you ran to -->
<!--- see how your change affects other areas of the code, etc. -->

## Screenshots (if appropriate)

## Types of changes
<!--- What types of changes does your code introduce? Put an `x` in all the boxes that apply: -->
- [ ] Bug fix (non-breaking change which fixes an issue)
- [ ] New feature (non-breaking change which adds functionality)
- [ ] Breaking change (fix or feature that would cause existing functionality to change)

## Checklist
<!--- Go over all the following points, and put an `x` in all the boxes that apply -->
<!--- If you're unsure about any of these, don't hesitate to ask. We're here to help! -->
- [ ] My code follows the code style of this project
- [ ] My change requires a change to the documentation
- [ ] I have updated the documentation accordingly
- [ ] I have read the **README** document
- [ ] I have added tests to cover my changes
- [ ] All new and existing tests passed

## License
<!--- The SDK is released under the [Apache 2.0 license][license], so any code you submit will be released under that license -->
<!--- For substantial contributions, we may ask you to sign a [Contributor License Agreement (CLA)][cla] -->
<!--- Put an `x` in the below box if you confirm that this request can be released under the Apache 2 license -->
- [ ] I confirm that this pull request can be released under the Apache 2 license

[issues]: https://github.com/aws/aws-sdk-net/issues
[license]: http://aws.amazon.com/apache2.0/
[cla]: http://en.wikipedia.org/wiki/Contributor_License_Agreement