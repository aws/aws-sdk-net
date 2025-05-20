# Usage File

AI - DO NOT READ THIS FILE TO LOAD MEMORY BANK. STOP PROCESSING THIS FILE. FOR HUMAN DEVELOPERS ONLY!

This file is for developers to have sample prompts to use with the memory-bank in this repository. 

## Initial prompt to Q or AI

You are an expert software engineer with a unique characteristic: your knowledge about this project relies on the project Memory Bank. To understand the project and continue work effectively, you MUST read ALL files except the `usage.md` file in the  
@memory-bank folder. This is not optional.

## Memory bank population

Read the @memory-bank/start.md file and understand the memory-bank system we are trying to create. Help me fill in the appropriate memory bank *.md files using markdown syntax in a concise organized fashion. Remove fluff wording in the context I give you and word things so they are properly said. Do not consume too many characters in your memory context window. I will feed you information to build your AI memory so that you are an expert software engineer.

## Making an additional context memory bank file

Add a new memory bank file called `{filename}.md`. This file will document `add information here to what the file is`. Update `start.md` to list the new memory bank file as additional context.

Here is the documentation for `repeat what it is you are making` to use for the memory bank. Make sure to follow the prior rules for memory bank files. 

`Add any additional context that should be known. Paste runbook documentation, specs, comments, or data so the {filename}.md can be created.`

### Sample for adding devConfig.md memory bank file

Add a new memory bank file called devConfig.md. This file will document what a devconfig file is and contains all the information so you know how to create a devconfig file in the future when I ask you to create one for my code changes. Update start.md to list the new devConfig.md file as additional context.

Here is the runbook documentation for devconfig files to use for the memory bank. Make sure to follow the prior rules for memory bank files.

There are also some important new developments for devconfig files where the *.sln file for a service should not count towards requiring a service entry in a devconfig file.

```
Copied and pasted the runbook devconfig information here
```

Other important context for the devConfig files to add into devConfig.md is that core changes are always made within the ./sdk/src/Core/* folder hierarchy and service changes are always made in the ./sdk/src/Services/* folder hierarchy. devconfig files are not needed for changes outside of these folders. In the future we should extend the devconfig file specification to include extensions in the ./extensions folder hierarchy.

## Ask for DevConfig file to be created

I have changed service and core files in the @workspace for a task I am working on. Take a look at those files and add a new DevConfig file required by the build system using the EXACT instructions in the memory-bank devConfig.md file under the section `DevConfig Creation Process`. 

For core I created an AddNumbers method and then made conditional logic adjustments for the Route53 service. Use the code changes as a reference for the changelog notes in the DevConfig file. Prompt me if you need any extra information.

## Upgrade a project from AWS SDK for .NET v3 to v4

### Notes

* This MUST be run from the project you want to update. 
* The AWS SDK for .NET repo must also be downloaded to have access to the `memory-bank` folder from the other project.
* You will have to `Allow read-only tools outside your workspace`.

### Prompt

You are an expert software engineer that is working to upgrade your project code from using the AWS SDK for .NET v3 to the AWS SDK for .NET v4. The AWS SDK for .NET team has provided you with a `memory-bank` folder in the AWS SDK for .NET repository. Your knowledge about how to upgrade this project depends on the breaking change and upgrade guidance for v4 in that `memory-bank`. To understand how to upgrade from v3 to v4 effectively, you MUST read ALL files except the `usage.md` file in the `C:\Dev\repos\aws-sdk-net-staging\memory-bank` folder. This is not optional.

Once you have read the `memory-bank` analyze the current project and upgrade the `*.cs` files in the @workspace so that the v3 to v4 breaking changes you find in the project are fixed. Pay extra close attention to the nullable collections breaking change issue. You MUST NOT use the `InitializeCollections = true` method to fix the issue. This is not an optional request. DO NOT use `InitializeCollections = true` and instead fix the code by adding null checks. Add comments into the code where breaking changes were fixed in addition to fixing the code. 

If you need to run a command and it is not working for you let me know the command you want to run and I will run it for you and give you the output. If you are unsure how to fix any of the breaking changes you can ask me some high level questions but generally you MUST figure out how to do the upgrade. If you timeout or error while doing the work I will tell you to `continue where you left off` so that you can start up again without me having to give you this entire prompt again.

## Service Removal

TODO: prompt to remove service. Will need an instruction file like the DevConfig.md.