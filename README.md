# clean-architecture-demo
Implementing Clean Architecture on a .NET demo project

## Use Cases

### Get a product list

Data:
- ProductId
- Title
- Price

Flow:
- User request command to see product list
- System returns data to the user

### Get a product details when select from the previous list

Data:
- ProductId
- Title
- Brand
- Price
- Stock

Flow:
- User request command to see product details
- System returns data to the user
