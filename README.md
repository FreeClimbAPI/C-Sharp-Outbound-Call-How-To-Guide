# C# - Make an Outbound Call

This project serves as a guide to help you build an application with FreeClimb. View this tutorial on [FreeClimb.com](https://docs.freeclimb.com/docs/accept-an-incoming-call#section-c). Specifically, the project will:

- Create an outbound call and control call

## Setting up your new app within your FreeClimb account

To get started using a FreeClimb account, follow the instructions [here](https://docs.freeclimb.com/docs/getting-started-with-freeclimb).

## Setting up the Tutorial

1. Install the nuget packages necessary using command:

   ```bash
   $ dotnet add package freeclimb-cs-sdk --version 1.0.0.2
   ```
2. Configure environment variables.

| ENV VARIABLE | DESCRIPTION                                                                                                                              |
| ------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| ACCOUNT_ID   | Account ID which can be found under [API Keys](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard           |
| AUTH_TOKEN   | Authentication Token which can be found under [API Keys](https://www.freeclimb.com/dashboard/portal/account/authentication) in Dashboard |

3. Provide a value for the variables `to`, `from`, and `appId` in FreeClimbController.cs. The `to` number is any phone number you wish to call. This number must be [verified](https://docs.freeclimb.com/docs/using-your-trial-account#section-verifying-outbound-numbers) (for trial users) and in E.164 format. `from` is a FreeClimb number that makes the call ([Incoming Numbers](https://www.freeclimb.com/dashboard/portal/numbers)). `appId` is the id of the app which you wish to handle the call. 


## Runnning the Tutorial

1. Run the application using command:

   ```bash
   $ dotnet run
   ```

