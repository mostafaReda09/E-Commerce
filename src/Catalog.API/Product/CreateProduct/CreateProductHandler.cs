using MediatR;
using Shared.CQRS;

namespace Catalog.API.Product.CreateProduct
{
    public record CreateProductCommand(string Name,
        List<string> Category,
        string Description,
        string ImageUrl,
        double Price): ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
