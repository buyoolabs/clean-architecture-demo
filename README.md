# clean-architecture-demo
Implementing Clean Architecture on a .NET demo project

## Use Cases

1. Get a product list

Data:
- ProductId
- Title
- Price

Flow:
- User request command to see product list
- System returns data to the user

2. Get a product details when select from the previous list

Data:
- ProductId
- Title
- Brand
- Price
- Stock

Flow:
- User request command to see product details
- System returns data to the user
