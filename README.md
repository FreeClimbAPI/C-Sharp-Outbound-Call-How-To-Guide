# C# - Make an Outbound Call How-To Guide

This project serves as a guide to help you build an application with FreeClimb. View this how-to guide on [FreeClimb.com](https://docs.freeclimb.com/docs/how-to-make-an-outbound-call#section-c). Specifically, the project will:

- Create an outbound call and control call

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the how-to guide

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk
   ```
2. Configure environment variables.

| ENV VARIABLE | DESCRIPTION                                                                                                                              |
| ------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| ACCOUNT_ID   | Account ID which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard           |
| API_KEY   | API key which can be found under [API credentials](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard |

3. Provide a value for the variables `to`, `from`, and `appId` in FreeClimbController.cs. The `to` number is any phone number you wish to call. This number must be [verified](https://docs.freeclimb.com/docs/using-your-trial-account#section-verifying-outbound-numbers) (for trial users) and in E.164 format. `from` is a FreeClimb number that makes the call ([Incoming Numbers](https://www.freeclimb.com/dashboard/portal/numbers)). `appId` is the id of the app which you wish to handle the call. 


## Runnning the how-to guide

1. Run the application using command:

   ```bash
   $ dotnet run
   ```


## Getting Help

If you are experiencing difficulties, [contact support](https://freeclimb.com/support).
