using Xunit;

#if !BCL35
[assembly: CollectionBehavior(DisableTestParallelization = true)]
#endif