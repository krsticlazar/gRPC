# Distributed Systems gRPC Practice Projects

This repository contains .NET gRPC lab and exam preparation projects for the **Distributed Systems** course at the Faculty of Electronic Engineering, University of Nis.

The work focuses on building small client/server distributed applications with **gRPC**, **Protocol Buffers**, and **C#/.NET**, with an emphasis on understanding how service contracts, generated stubs, message types, and streaming RPC calls work in practice.

## What This Repository Demonstrates

- Designing `.proto` contracts with services, request messages, response messages, `repeated` fields, and `google.protobuf.Empty`.
- Implementing gRPC services in ASP.NET Core using generated base classes.
- Building console clients that communicate with gRPC servers through generated client stubs.
- Using all main gRPC communication patterns: unary RPC, server streaming, client streaming, and bidirectional streaming.
- Managing simple in-memory server state through helper classes and singleton-style storage.
- Preparing exam-style solutions where the key focus is the `.proto` file, service implementation, and reasoning about request/response flow.

## Technologies

- C#
- .NET
- ASP.NET Core gRPC
- Protocol Buffers
- Visual Studio
- Console client applications

## Project Structure

| Folder | Description |
| --- | --- |
| `DSLab1Grpc/` | Main lab template used for practicing basic gRPC project setup and service implementation. |
| `Oktobar2/` | Practice project focused on streaming behavior and client/server communication flow. |
| `KOL24/` | Solved KOL 1 2024 exam-style task: task management service with add, list, and complete operations. |
| `JUN24/` | Solved JUN 2024 exam-style task: message management service with message sending, deletion, and server streaming. |
| `APRIL26/` | Practice skeleton and implementation exercise for a calculator-style gRPC service. |

## Key Learning Outcomes

The repository shows how to:

- Define a gRPC API before writing the server logic.
- Map proto definitions to generated C# classes and service base classes.
- Decide when to use a normal response object, `repeated` fields, or `stream`.
- Separate the server-side data model from the gRPC response model.
- Test gRPC services locally by running the server and one or more console clients.

## Study Materials

The repository also contains exam preparation notes and summarized explanations:

- `skripta_final.md` - consolidated gRPC theory notes.
- `moji_zakljucci.md` - short practical conclusions and syntax patterns for exam revision.
- `ispitni zadaci.txt` - collected exam-style task descriptions.

## Running the Projects

Each solved task follows the same general workflow:

1. Open the solution in Visual Studio.
2. Start the server project first.
3. Start the console client project in a separate terminal or Visual Studio profile.
4. Test the available operations through the client menu.

For command-line testing, the usual pattern is:

```powershell
dotnet run --project .\PROJECT_FOLDER\PROJECTServer\PROJECTServer.csproj --launch-profile https
dotnet run --project .\PROJECT_FOLDER\PROJECTClient\PROJECTClient.csproj
```

## Purpose

This repository is intended as a compact portfolio of hands-on distributed systems practice: defining gRPC contracts, implementing services, handling generated code, and testing distributed client/server workflows in .NET.
