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
using System;
using System.Collections.Generic;
using Amazon.EC2.Model;
using Amazon.Runtime;
using System.Reflection;
using System.Net;
using Amazon.Util.Internal;


namespace Amazon.EC2
{
    /// <summary>
    /// Implementation for accessing AmazonEC2.
    ///  
    /// <para> Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to
    /// make web-scale computing easier for developers. </para> <para> Amazon EC2's simple web service interface allows you to obtain and configure
    /// capacity with minimal friction. It provides you with complete control of your computing resources and lets you run on Amazon's proven
    /// computing environment. Amazon EC2 reduces the time required to obtain and boot new server instances to minutes, allowing you to quickly
    /// scale capacity, both up and down, as your computing requirements change. Amazon EC2 changes the economics of computing by allowing you to
    /// pay only for capacity that you actually use. Amazon EC2 provides developers the tools to build failure resilient applications and isolate
    /// themselves from common failure scenarios. </para> <para> Visit http://aws.amazon.com/ec2/ for more information. </para>
    /// </summary>
    public partial class AmazonEC2Client : AmazonServiceClient, IAmazonEC2
    {
        #region DryRun

        private class DryRunInfo
        {
            public MethodInfo Method { get; private set; }

            public DryRunInfo(MethodInfo method)
            {
                Method = method;
            }

            public void DryRun(AmazonEC2Client client, AmazonEC2Request request, ref DryRunResponse response)
            {
                response.IsSuccessful = false;

                SetDryRun(request, true);
                try
                {
                    Method.Invoke(client, new object[] { request });
                    // If no exception thrown, consider this a failure
                    response.Message = "Unrecognized service response for the dry-run request.";
                }
                catch (Exception invokeException)
                {
                    Exception actualException = invokeException.InnerException;
                    AmazonEC2Exception ec2e = actualException as AmazonEC2Exception;

                    response.Message = actualException.Message;
                    if (ec2e != null)
                    {
                        response.IsSuccessful = ec2e.StatusCode == HttpStatusCode.PreconditionFailed;
                        response.ResponseMetadata = new ResponseMetadata
                        {
                            RequestId = ec2e.RequestId
                        };
                    }

                    if (!response.IsSuccessful)
                        response.Error = actualException;
                }
                finally
                {
                    SetDryRun(request, false);
                }
            }

            private void SetDryRun(AmazonEC2Request request, bool value)
            {
                if (value)
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest )request).AddBeforeRequestHandler(SetDryRunParameterCallback);
                else
                    ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request).RemoveBeforeRequestHandler(SetDryRunParameterCallback);
            }

            private void SetDryRunParameterCallback(object sender, RequestEventArgs args)
            {
                WebServiceRequestEventArgs wsrea = args as WebServiceRequestEventArgs;
                if (wsrea != null)
                {
                    wsrea.ParameterCollection["DryRun"] = new StringParameterValue("true");
                }
            }
        }

        private static Dictionary<Type, DryRunInfo> _methodCache = null;
        private static Dictionary<Type, DryRunInfo> MethodCache
        {
            get
            {
                if (_methodCache == null)
                {
                    _methodCache = new Dictionary<Type, DryRunInfo>();

                    var ec2RequestType = typeof(AmazonEC2Request);
                    var allMembers = typeof(AmazonEC2Client).GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    foreach (var member in allMembers)
                    {
                        MethodInfo method = member as MethodInfo;
                        if (method == null)
                            continue;

                        // Return type must be named "*Response"
                        var returnType = method.ReturnType;
                        if (!returnType.Name.EndsWith("Response", StringComparison.OrdinalIgnoreCase))
                            continue;

                        // There must be only one input parameter
                        var parameters = method.GetParameters();
                        if (parameters.Length != 1)
                            continue;

                        // The input parameter must extend EC2Request, but must not be EC2Request
                        var inputType = parameters[0].ParameterType;
                        if (inputType == ec2RequestType || !ec2RequestType.IsAssignableFrom(inputType))
                            continue;

                        // Method name must match: [Name]Request = [InputTypeName]
                        if (!string.Equals(method.Name + "Request", inputType.Name, StringComparison.OrdinalIgnoreCase))
                            continue;

                        _methodCache[inputType] = new DryRunInfo(method);
                    }
                }

                return _methodCache;
            }
        }

        /// <summary>
        /// Checks whether you have the required permissions for the action, without actually making the request.
        /// </summary>
        /// <param name="request">Request to do a dry run of.</param>
        /// <returns>Result of the dry run.</returns>
        [Obsolete("This method has been deprecated. Use DryRun property at request level instead.")]
        public DryRunResponse DryRun(AmazonEC2Request request)
        {
            DryRunResponse response = new DryRunResponse { IsSuccessful = false };

            if (request == null)
            {
                response.Message = "Request must not be null";
                return response;
            }

            DryRunInfo dryRunInfo;
            Type requestType = request.GetType();
            if (!MethodCache.TryGetValue(requestType, out dryRunInfo) || dryRunInfo == null)
            {
                response.Message = "Unrecognized request";
                return response;
            }

            dryRunInfo.DryRun(this, request, ref response);
            return response;
        }

        #endregion
    }
}
