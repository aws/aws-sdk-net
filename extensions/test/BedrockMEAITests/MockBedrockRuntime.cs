using Amazon.BedrockRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.BedrockRuntime;

internal sealed class MockBedrockRuntime : IAmazonBedrockRuntime
{
    public Func<ConverseRequest, ConverseResponse> OnConverseRequest { get; set; }
    public Func<ConverseStreamRequest, ConverseStreamResponse> OnConverseStreamRequest { get; set; }

    public IClientConfig Config => throw new NotImplementedException();
    public IBedrockRuntimePaginatorFactory Paginators => throw new NotImplementedException();

    public async Task<ConverseResponse> ConverseAsync(ConverseRequest request, CancellationToken cancellationToken = default)
    {
        if (OnConverseRequest is null)
        {
            throw new NotSupportedException($"{nameof(ConverseAsync)} was invoked but no {nameof(OnConverseRequest)} was provided.");
        }

        return OnConverseRequest(request);
    }

    public async Task<ConverseStreamResponse> ConverseStreamAsync(ConverseStreamRequest request, CancellationToken cancellationToken = default)
    {
        if (OnConverseStreamRequest is null)
        {
            throw new NotSupportedException($"{nameof(ConverseStreamAsync)} was invoked but no {nameof(OnConverseStreamRequest)} was provided.");
        }

        return OnConverseStreamRequest(request);
    }

    public void Dispose() { }

    public ConverseResponse Converse(ConverseRequest request) => throw new NotImplementedException();
    public ConverseStreamResponse ConverseStream(ConverseStreamRequest request) => throw new NotImplementedException();
    public ApplyGuardrailResponse ApplyGuardrail(ApplyGuardrailRequest request) => throw new NotImplementedException();
    public Task<ApplyGuardrailResponse> ApplyGuardrailAsync(ApplyGuardrailRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public CountTokensResponse CountTokens(CountTokensRequest request) => throw new NotImplementedException();
    public Task<CountTokensResponse> CountTokensAsync(CountTokensRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public GetAsyncInvokeResponse GetAsyncInvoke(GetAsyncInvokeRequest request) => throw new NotImplementedException();
    public Task<GetAsyncInvokeResponse> GetAsyncInvokeAsync(GetAsyncInvokeRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public InvokeModelResponse InvokeModel(InvokeModelRequest request) => throw new NotImplementedException();
    public Task<InvokeModelResponse> InvokeModelAsync(InvokeModelRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public InvokeModelWithResponseStreamResponse InvokeModelWithResponseStream(InvokeModelWithResponseStreamRequest request) => throw new NotImplementedException();
    public Task<InvokeModelWithResponseStreamResponse> InvokeModelWithResponseStreamAsync(InvokeModelWithResponseStreamRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public ListAsyncInvokesResponse ListAsyncInvokes(ListAsyncInvokesRequest request) => throw new NotImplementedException();
    public Task<ListAsyncInvokesResponse> ListAsyncInvokesAsync(ListAsyncInvokesRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public StartAsyncInvokeResponse StartAsyncInvoke(StartAsyncInvokeRequest request) => throw new NotImplementedException();
    public Task<StartAsyncInvokeResponse> StartAsyncInvokeAsync(StartAsyncInvokeRequest request, CancellationToken cancellationToken = default) => throw new NotImplementedException();
    public Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request) => throw new NotImplementedException();
}
