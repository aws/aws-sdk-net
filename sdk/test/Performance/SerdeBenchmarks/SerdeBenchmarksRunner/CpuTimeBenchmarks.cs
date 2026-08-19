/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System.Formats.Cbor;
using System.Text;
using Amazon.JsonRpc10DataPlane;
using Amazon.JsonRpc10DataPlane.Model;
using Amazon.QueryDataPlane;
using Amazon.RestJsonDataPlane;
using Amazon.RestXmlDataPlane;
using Amazon.RpcCborDataPlane;
using Amazon.Runtime;
using AV_Json = Amazon.JsonRpc10DataPlane.Model.AttributeValue;
using AV_Cbor = Amazon.RpcCborDataPlane.Model.AttributeValue;

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Sets up and runs all 71 E2E benchmarks for ops/CPU-sec measurement.
/// This is separate from BDN's E2E suite (43 benchmarks) which is used by roadrunner.
/// The extra 28 benchmarks cover binary, nested, and shallow map payload variants
/// for AwsJson10 and RpcV2Cbor, plus L-size variants for AwsQuery.
/// </summary>
public static class CpuTimeBenchmarks
{
    public static async Task<List<CpuTimeRunner.CpuTimeResult>> RunAll()
    {
        var all = new List<CpuTimeRunner.CpuTimeResult>();

        all.AddRange(await RunAwsJson10());
        all.AddRange(await RunRestJson1());
        all.AddRange(await RunRpcV2Cbor());
        all.AddRange(await RunRestXml());
        all.AddRange(await RunAwsQuery());

        return all;
    }

    // ==================== AwsJson10 (20 benchmarks) ====================

    private static async Task<List<CpuTimeRunner.CpuTimeResult>> RunAwsJson10()
    {
        var emptyJson = Encoding.UTF8.GetBytes("{}");

        AmazonJsonRpc10DataPlaneClient CreateClient(byte[] body)
        {
            var handler = new MockHttpHandler(body, "application/x-amz-json-1.0");
            var config = new AmazonJsonRpc10DataPlaneConfig { RegionEndpoint = Amazon.RegionEndpoint.USWest2, HttpClientFactory = new MockHttpClientFactory(handler) };
            return new AmazonJsonRpc10DataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
        }

        AV_Json S(string v) => new AV_Json { S = v };
        AV_Json N(double n) => new AV_Json { N = n.ToString() };
        AV_Json BOOL(bool b) => new AV_Json { BOOL = b };
        AV_Json L(List<AV_Json> l) => new AV_Json { L = l };
        AV_Json M(Dictionary<string, AV_Json> m) => new AV_Json { M = m };
        AV_Json B(MemoryStream ms) => new AV_Json { B = ms };

        // Responses
        var getBaselineResp = emptyJson;
        var getSResp = Encoding.UTF8.GetBytes(BuildJsonGetItem(5));
        var getMResp = Encoding.UTF8.GetBytes(BuildJsonGetItem(20));
        var getLResp = Encoding.UTF8.GetBytes(BuildJsonGetItem(50));
        var getBinSResp = Encoding.UTF8.GetBytes(BuildJsonBinaryGetItem(TestDataHelpers.SmallBinarySize));
        var getBinMResp = Encoding.UTF8.GetBytes(BuildJsonBinaryGetItem(TestDataHelpers.MediumBinarySize));
        var getBinLResp = Encoding.UTF8.GetBytes(BuildJsonBinaryGetItem(TestDataHelpers.LargeBinarySize));

        // Clients
        var healthClient = CreateClient(emptyJson);
        var putClient = CreateClient(emptyJson);
        var getBaselineClient = CreateClient(getBaselineResp);
        var getSClient = CreateClient(getSResp);
        var getMClient = CreateClient(getMResp);
        var getLClient = CreateClient(getLResp);
        var getBinSClient = CreateClient(getBinSResp);
        var getBinMClient = CreateClient(getBinMResp);
        var getBinLClient = CreateClient(getBinLResp);

        // Requests
        var healthReq = new Amazon.JsonRpc10DataPlane.Model.HealthcheckRequest();
        var getReq = new Amazon.JsonRpc10DataPlane.Model.GetItemRequest { TableName = "T", Key = TestDataHelpers.CreateBaselineItem<AV_Json>(S) };
        var putBaseline = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBaselineItem<AV_Json>(S) };
        var putBinS = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Json>(S, B, TestDataHelpers.SmallBinarySize) };
        var putBinM = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Json>(S, B, TestDataHelpers.MediumBinarySize) };
        var putBinL = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Json>(S, B, TestDataHelpers.LargeBinarySize) };
        var putMixS = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateSmallItem<AV_Json>(S, N, BOOL) };
        var putMixM = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateMediumItem<AV_Json>(S, N, BOOL, L, M) };
        var putMixL = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateLargeItem<AV_Json>(S, N, BOOL, L, M) };
        var putNestM = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateNestedItem<AV_Json>(S, M, TestDataHelpers.MediumNestingDepth) };
        var putNestL = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateNestedItem<AV_Json>(S, M, TestDataHelpers.LargeNestingDepth) };
        var putShallS = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Json>(S, TestDataHelpers.SmallShallowMapKeys) };
        var putShallM = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Json>(S, TestDataHelpers.MediumShallowMapKeys) };
        var putShallL = new Amazon.JsonRpc10DataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Json>(S, TestDataHelpers.LargeShallowMapKeys) };

        var results = new List<CpuTimeRunner.CpuTimeResult>
        {
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_Healthcheck", () => healthClient.HealthcheckAsync(healthReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItem_Baseline", () => getBaselineClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItem_S", () => getSClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItem_M", () => getMClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItem_L", () => getLClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItemBinary_S", () => getBinSClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItemBinary_M", () => getBinMClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_GetItemBinary_L", () => getBinLClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Baseline", () => putClient.PutItemAsync(putBaseline)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Binary_S", () => putClient.PutItemAsync(putBinS)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Binary_M", () => putClient.PutItemAsync(putBinM)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Binary_L", () => putClient.PutItemAsync(putBinL)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Mixed_S", () => putClient.PutItemAsync(putMixS)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Mixed_M", () => putClient.PutItemAsync(putMixM)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Mixed_L", () => putClient.PutItemAsync(putMixL)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Nested_M", () => putClient.PutItemAsync(putNestM)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_Nested_L", () => putClient.PutItemAsync(putNestL)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_ShallowMap_S", () => putClient.PutItemAsync(putShallS)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_ShallowMap_M", () => putClient.PutItemAsync(putShallM)),
            await CpuTimeRunner.MeasureAsync("awsJson10_e2e_PutItem_ShallowMap_L", () => putClient.PutItemAsync(putShallL)),
        };

        CpuTimeRunner.PrintResults(results, "AwsJson10 (DynamoDB) [20]");
        healthClient.Dispose(); putClient.Dispose();
        getBaselineClient.Dispose(); getSClient.Dispose(); getMClient.Dispose(); getLClient.Dispose();
        getBinSClient.Dispose(); getBinMClient.Dispose(); getBinLClient.Dispose();
        return results;
    }

    // ==================== RestJson1 (14 benchmarks) ====================

    private static async Task<List<CpuTimeRunner.CpuTimeResult>> RunRestJson1()
    {
        var b = new RestJson1E2EBenchmarks();
        b.Setup();
        var results = new List<CpuTimeRunner.CpuTimeResult>
        {
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_CopyObject_Baseline", () => b._copyClientBaseline.CopyObjectAsync(b._copyObjectBaseline)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_CopyObject_M", () => b._copyClientM.CopyObjectAsync(b._copyObjectMedium)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutObject_S", () => { b._putObjectS.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectS); }),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutObject_M", () => { b._putObjectM.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectM); }),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutObject_L", () => { b._putObjectL.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectL); }),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetObject_S", () => b._getClientS.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetObject_M", () => b._getClientM.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetObject_L", () => b._getClientL.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutMetricData_S", () => b._putMetricClientS.PutMetricDataAsync(b._putMetricDataS)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutMetricData_M", () => b._putMetricClientM.PutMetricDataAsync(b._putMetricDataM)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_PutMetricData_L", () => b._putMetricClientL.PutMetricDataAsync(b._putMetricDataL)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetMetricData_S", () => b._getMetricClientS.GetMetricDataAsync(b._getMetricDataS)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetMetricData_M", () => b._getMetricClientM.GetMetricDataAsync(b._getMetricDataM)),
            await CpuTimeRunner.MeasureAsync("restJson1_e2e_GetMetricData_L", () => b._getMetricClientL.GetMetricDataAsync(b._getMetricDataL)),
        };
        CpuTimeRunner.PrintResults(results, "RestJson1 (Lambda/CloudWatch) [14]");
        b.Cleanup();
        return results;
    }

    // ==================== RpcV2Cbor (19 benchmarks) ====================

    private static async Task<List<CpuTimeRunner.CpuTimeResult>> RunRpcV2Cbor()
    {
        var emptyCbor = new byte[] { 0xA0 };

        AmazonRpcCborDataPlaneClient CreateClient(byte[] body)
        {
            var headers = new Dictionary<string, string> { ["smithy-protocol"] = "rpc-v2-cbor" };
            var handler = new MockHttpHandler(body, "application/cbor", responseHeaders: headers);
            var config = new AmazonRpcCborDataPlaneConfig { RegionEndpoint = Amazon.RegionEndpoint.USWest2, HttpClientFactory = new MockHttpClientFactory(handler) };
            return new AmazonRpcCborDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
        }

        AV_Cbor S(string v) => new AV_Cbor { S = v };
        AV_Cbor N(double n) => new AV_Cbor { N = n.ToString() };
        AV_Cbor BOOL(bool b) => new AV_Cbor { BOOL = b };
        AV_Cbor L(List<AV_Cbor> l) => new AV_Cbor { L = l };
        AV_Cbor M(Dictionary<string, AV_Cbor> m) => new AV_Cbor { M = m };
        AV_Cbor B(MemoryStream ms) => new AV_Cbor { B = ms };

        var getBaselineResp = emptyCbor;
        var getSResp = BuildCborGetItem(5);
        var getMResp = BuildCborGetItem(20);
        var getLResp = BuildCborGetItem(50);
        var getBinSResp = BuildCborBinaryGetItem(TestDataHelpers.SmallBinarySize);
        var getBinMResp = BuildCborBinaryGetItem(TestDataHelpers.MediumBinarySize);
        var getBinLResp = BuildCborBinaryGetItem(TestDataHelpers.LargeBinarySize);

        var putClient = CreateClient(emptyCbor);
        var getBaselineClient = CreateClient(getBaselineResp);
        var getSClient = CreateClient(getSResp);
        var getMClient = CreateClient(getMResp);
        var getLClient = CreateClient(getLResp);
        var getBinSClient = CreateClient(getBinSResp);
        var getBinMClient = CreateClient(getBinMResp);
        var getBinLClient = CreateClient(getBinLResp);

        var getReq = new Amazon.RpcCborDataPlane.Model.GetItemRequest { TableName = "T", Key = TestDataHelpers.CreateBaselineItem<AV_Cbor>(S) };
        var putBaseline = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBaselineItem<AV_Cbor>(S) };
        var putBinS = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Cbor>(S, B, TestDataHelpers.SmallBinarySize) };
        var putBinM = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Cbor>(S, B, TestDataHelpers.MediumBinarySize) };
        var putBinL = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateBinaryItem<AV_Cbor>(S, B, TestDataHelpers.LargeBinarySize) };
        var putMixS = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateSmallItem<AV_Cbor>(S, N, BOOL) };
        var putMixM = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateMediumItem<AV_Cbor>(S, N, BOOL, L, M) };
        var putMixL = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateLargeItem<AV_Cbor>(S, N, BOOL, L, M) };
        var putNestM = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateNestedItem<AV_Cbor>(S, M, TestDataHelpers.MediumNestingDepth) };
        var putNestL = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateNestedItem<AV_Cbor>(S, M, TestDataHelpers.LargeNestingDepth) };
        var putShallS = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Cbor>(S, TestDataHelpers.SmallShallowMapKeys) };
        var putShallM = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Cbor>(S, TestDataHelpers.MediumShallowMapKeys) };
        var putShallL = new Amazon.RpcCborDataPlane.Model.PutItemRequest { TableName = "T", Item = TestDataHelpers.CreateShallowMapItem<AV_Cbor>(S, TestDataHelpers.LargeShallowMapKeys) };

        var results = new List<CpuTimeRunner.CpuTimeResult>
        {
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItem_Baseline", () => getBaselineClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItem_S", () => getSClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItem_M", () => getMClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItem_L", () => getLClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItemBinary_S", () => getBinSClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItemBinary_M", () => getBinMClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_GetItemBinary_L", () => getBinLClient.GetItemAsync(getReq)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Baseline", () => putClient.PutItemAsync(putBaseline)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Binary_S", () => putClient.PutItemAsync(putBinS)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Binary_M", () => putClient.PutItemAsync(putBinM)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Binary_L", () => putClient.PutItemAsync(putBinL)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Mixed_S", () => putClient.PutItemAsync(putMixS)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Mixed_M", () => putClient.PutItemAsync(putMixM)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Mixed_L", () => putClient.PutItemAsync(putMixL)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Nested_M", () => putClient.PutItemAsync(putNestM)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_Nested_L", () => putClient.PutItemAsync(putNestL)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_ShallowMap_S", () => putClient.PutItemAsync(putShallS)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_ShallowMap_M", () => putClient.PutItemAsync(putShallM)),
            await CpuTimeRunner.MeasureAsync("rpcV2Cbor_e2e_PutItem_ShallowMap_L", () => putClient.PutItemAsync(putShallL)),
        };

        CpuTimeRunner.PrintResults(results, "RpcV2Cbor [19]");
        putClient.Dispose(); getBaselineClient.Dispose();
        getSClient.Dispose(); getMClient.Dispose(); getLClient.Dispose();
        getBinSClient.Dispose(); getBinMClient.Dispose(); getBinLClient.Dispose();
        return results;
    }

    // ==================== RestXml (11 benchmarks) ====================

    private static async Task<List<CpuTimeRunner.CpuTimeResult>> RunRestXml()
    {
        var b = new RestXmlE2EBenchmarks();
        b.Setup();
        var results = new List<CpuTimeRunner.CpuTimeResult>
        {
            await CpuTimeRunner.MeasureAsync("restXml_e2e_CopyObject", () => b._copyClient.CopyObjectAsync(b._copyObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_PutObject_S", () => { b._putObjectS.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectS); }),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_PutObject_M", () => { b._putObjectM.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectM); }),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_PutObject_L", () => { b._putObjectL.Body.Position = 0; return b._putClient.PutObjectAsync(b._putObjectL); }),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_GetObject_S", () => b._getClientS.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_GetObject_M", () => b._getClientM.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_GetObject_L", () => b._getClientL.GetObjectAsync(b._getObjectRequest)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_PutMetricData_S", () => b._putMetricClientS.PutMetricDataAsync(b._putMetricDataS)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_PutMetricData_M", () => b._putMetricClientM.PutMetricDataAsync(b._putMetricDataM)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_GetMetricData_S", () => b._getMetricClientS.GetMetricDataAsync(b._getMetricDataS)),
            await CpuTimeRunner.MeasureAsync("restXml_e2e_GetMetricData_M", () => b._getMetricClientM.GetMetricDataAsync(b._getMetricDataM)),
        };
        CpuTimeRunner.PrintResults(results, "RestXml (S3) [11]");
        b.Cleanup();
        return results;
    }

    // ==================== AwsQuery (7 benchmarks) ====================

    private static async Task<List<CpuTimeRunner.CpuTimeResult>> RunAwsQuery()
    {
        var b = new AwsQueryE2EBenchmarks();
        b.Setup();

        // L variants need their own clients/requests (not in the BDN class)
        var putRespBytes = Encoding.UTF8.GetBytes(
            "<PutMetricDataResponse xmlns=\"https://query.amazonaws.com/doc/2024-01-01/\"><PutMetricDataResult/><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></PutMetricDataResponse>");
        var getLRespBytes = Encoding.UTF8.GetBytes(BuildQueryGetMetricXml(200));

        var putClientL = CreateQueryClient(putRespBytes);
        var getClientL = CreateQueryClient(getLRespBytes);

        var putMetricL = new Amazon.QueryDataPlane.Model.PutMetricDataRequest { Namespace = "Test", MetricData = CreateQueryMetricData(100) };
        var getMetricL = new Amazon.QueryDataPlane.Model.GetMetricDataRequest
        {
            StartTime = DateTime.UtcNow.AddHours(-1),
            EndTime = DateTime.UtcNow,
            MetricDataQueries = CreateQueryQueries(20)
        };

        var results = new List<CpuTimeRunner.CpuTimeResult>
        {
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_Healthcheck", () => b._healthcheckClient.HealthcheckAsync(b._healthcheckRequest)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_PutMetricData_S", () => b._putClientS.PutMetricDataAsync(b._putMetricDataS)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_PutMetricData_M", () => b._putClientM.PutMetricDataAsync(b._putMetricDataM)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_PutMetricData_L", () => putClientL.PutMetricDataAsync(putMetricL)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_GetMetricData_S", () => b._getClientS.GetMetricDataAsync(b._getMetricDataRequestS)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_GetMetricData_M", () => b._getClientM.GetMetricDataAsync(b._getMetricDataRequestM)),
            await CpuTimeRunner.MeasureAsync("awsQuery_e2e_GetMetricData_L", () => getClientL.GetMetricDataAsync(getMetricL)),
        };
        CpuTimeRunner.PrintResults(results, "AwsQuery (IAM/STS) [7]");
        b.Cleanup();
        putClientL.Dispose();
        getClientL.Dispose();
        return results;
    }

    // ==================== Helpers ====================

    private static string BuildJsonGetItem(int attrCount)
    {
        var sb = new StringBuilder("{\"Item\":{");
        for (int i = 0; i < attrCount; i++) { if (i > 0) sb.Append(','); sb.Append($"\"attr_{i}\":{{\"S\":\"value-{i}-{new string('x', 20)}\"}}"); }
        sb.Append("}}"); return sb.ToString();
    }

    private static string BuildJsonBinaryGetItem(int binarySize)
    {
        var data = new byte[binarySize]; Random.Shared.NextBytes(data);
        return $"{{\"Item\":{{\"pk\":{{\"S\":\"binary-item\"}},\"data\":{{\"B\":\"{Convert.ToBase64String(data)}\"}}}}}}";
    }

    private static byte[] BuildCborGetItem(int attributeCount)
    {
        var writer = new CborWriter();
        writer.WriteStartMap(1);
        writer.WriteTextString("Item");
        writer.WriteStartMap(attributeCount);
        for (int i = 0; i < attributeCount; i++)
        {
            writer.WriteTextString($"attr_{i}");
            writer.WriteStartMap(1); writer.WriteTextString("S"); writer.WriteTextString($"value-{i}-{new string('x', 20)}"); writer.WriteEndMap();
        }
        writer.WriteEndMap();
        writer.WriteEndMap();
        return writer.Encode();
    }

    private static byte[] BuildCborBinaryGetItem(int binarySize)
    {
        var data = new byte[binarySize]; Random.Shared.NextBytes(data);
        var writer = new CborWriter();
        writer.WriteStartMap(1);
        writer.WriteTextString("Item");
        writer.WriteStartMap(2);
        writer.WriteTextString("pk"); writer.WriteStartMap(1); writer.WriteTextString("S"); writer.WriteTextString("binary-item"); writer.WriteEndMap();
        writer.WriteTextString("data"); writer.WriteStartMap(1); writer.WriteTextString("B"); writer.WriteByteString(data); writer.WriteEndMap();
        writer.WriteEndMap();
        writer.WriteEndMap();
        return writer.Encode();
    }

    private static string BuildQueryGetMetricXml(int datapoints)
    {
        var sb = new StringBuilder("<GetMetricDataResponse xmlns=\"https://query.amazonaws.com/doc/2024-01-01/\"><GetMetricDataResult><MetricDataResults><member><Id>m1</Id><Label>CPUUtilization</Label><Values>");
        for (int i = 0; i < datapoints; i++) sb.Append($"<member>{42.0 + i * 0.1}</member>");
        sb.Append("</Values><Timestamps>");
        for (int i = 0; i < datapoints; i++) sb.Append($"<member>{new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMinutes(i * 5):yyyy-MM-ddTHH:mm:ssZ}</member>");
        sb.Append("</Timestamps></member></MetricDataResults></GetMetricDataResult><ResponseMetadata><RequestId>test-id</RequestId></ResponseMetadata></GetMetricDataResponse>");
        return sb.ToString();
    }

    private static AmazonQueryDataPlaneClient CreateQueryClient(byte[] responseBody)
    {
        var handler = new MockHttpHandler(responseBody, "text/xml");
        var config = new AmazonQueryDataPlaneConfig { RegionEndpoint = Amazon.RegionEndpoint.USWest2, HttpClientFactory = new MockHttpClientFactory(handler) };
        return new AmazonQueryDataPlaneClient(new BasicAWSCredentials("AKID", "SECRET"), config);
    }

    private static List<Amazon.QueryDataPlane.Model.MetricDatum> CreateQueryMetricData(int count)
    {
        var data = new List<Amazon.QueryDataPlane.Model.MetricDatum>();
        for (int i = 0; i < count; i++) data.Add(new Amazon.QueryDataPlane.Model.MetricDatum { MetricName = $"Metric{i}", Value = 42.0 + i, Unit = "Count" });
        return data;
    }

    private static List<Amazon.QueryDataPlane.Model.MetricDataQuery> CreateQueryQueries(int count)
    {
        var queries = new List<Amazon.QueryDataPlane.Model.MetricDataQuery>();
        for (int i = 0; i < count; i++) queries.Add(new Amazon.QueryDataPlane.Model.MetricDataQuery { Id = $"m{i}", MetricStat = new Amazon.QueryDataPlane.Model.MetricStat { Metric = new Amazon.QueryDataPlane.Model.Metric { MetricName = $"CPU{i}", Namespace = "AWS/EC2" }, Period = 300, Stat = "Average" } });
        return queries;
    }
}
