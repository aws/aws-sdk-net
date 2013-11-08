/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using System.Reflection;
using System.Net;
using Amazon.Util;
using System.Globalization;


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
    public partial class AmazonEC2Client : AmazonWebServiceClient, IAmazonEC2
    {
        #region Overrides

        protected override void Initialize()
        {
            base.Initialize();

            this.BeforeRequestEvent += BeforeRequestEvents;
            this.AfterResponseEvent += AfterResponseEvents;
        }

        #endregion

        #region After response events

        void AfterResponseEvents(object sender, ResponseEventArgs args)
        {
            var webArgs = args as WebServiceResponseEventArgs;
            if (webArgs != null)
            {
                var response = webArgs.Response;

                var dsirr = response as DescribeSpotInstanceRequestsResult;
                if (dsirr != null)
                {
                    if (dsirr.SpotInstanceRequests != null)
                    {
                        foreach (var spotInstanceRequest in dsirr.SpotInstanceRequests)
                        {
                            var launchSpecification = spotInstanceRequest.LaunchSpecification;
                            PopulateLaunchSpecificationSecurityGroupNames(launchSpecification);
                        }
                    }
                    return;
                }

                var rsir = response as RequestSpotInstancesResult;
                if (rsir != null)
                {
                    if (rsir.SpotInstanceRequests != null)
                    {
                        foreach (var spotInstanceRequest in rsir.SpotInstanceRequests)
                        {
                            var launchSpecification = spotInstanceRequest.LaunchSpecification;
                            PopulateLaunchSpecificationSecurityGroupNames(launchSpecification);
                        }
                    }
                    return;
                }

                var dir = response as DescribeInstancesResult;
                if (dir != null)
                {
                    if (dir.Reservations != null)
                    {
                        foreach (var reservation in dir.Reservations)
                        {
                            PopulateReservationSecurityGroupNames(reservation);
                        }
                    }
                    return;
                }

                var rir = response as RunInstancesResult;
                if (rir != null)
                {
                    PopulateReservationSecurityGroupNames(rir.Reservation);
                    return;
                }
            }
        }

        private static void PopulateLaunchSpecificationSecurityGroupNames(LaunchSpecification launchSpecification)
        {
            if (launchSpecification != null)
            {
                List<string> groupNames = new List<string>();
                foreach (GroupIdentifier group in launchSpecification.AllSecurityGroups)
                {
                    groupNames.Add(group.GroupName);
                }
                launchSpecification.SecurityGroups = groupNames;
            }
        }

        private static void PopulateReservationSecurityGroupNames(Reservation reservation)
        {
            if (reservation != null)
            {
                List<string> groupNames = new List<string>();
                foreach (GroupIdentifier group in reservation.Groups)
                {
                    groupNames.Add(group.GroupName);
                }
                reservation.GroupNames = groupNames;
            }
        }

        #endregion

        #region Before request events

        void BeforeRequestEvents(object sender, RequestEventArgs args)
        {
            var webArgs = args as WebServiceRequestEventArgs;
            if (webArgs != null)
            {
                var originalRequest = webArgs.Request;

                var rsir = originalRequest as RequestSpotInstancesRequest;
                if (rsir != null)
                {
                    if (rsir.LaunchSpecification != null && rsir.LaunchSpecification.AllSecurityGroups != null)
                    {
                        int count = 1;
                        foreach (var group in rsir.LaunchSpecification.AllSecurityGroups)
                        {
                            if (group != null && group.GroupId != null)
                            {
                                string key = "LaunchSpecification.SecurityGroupId." + count++;
                                webArgs.Parameters[key] = group.GroupId;
                            }
                        }
                    }

                    var keysToRemove = new List<string>();
                    foreach (var parameter in webArgs.Parameters.Keys)
                    {
                        if (parameter.StartsWith("LaunchSpecification.GroupSet.", StringComparison.Ordinal))
                            keysToRemove.Add(parameter);
                    }
                    foreach (var key in keysToRemove)
                    {
                        webArgs.Parameters.Remove(key);
                    }
                }
            }
        }

        #endregion

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
                    request.BeforeRequestEvent += SetDryRunParameterCallback;
                else
                    request.BeforeRequestEvent -= SetDryRunParameterCallback;
            }

            private void SetDryRunParameterCallback(object sender, RequestEventArgs args)
            {
                WebServiceRequestEventArgs wsrea = args as WebServiceRequestEventArgs;
                if (wsrea != null)
                {
                    wsrea.Parameters["DryRun"] = "true";
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
                    var ec2RequestTypeInfo = TypeFactory.GetTypeInfo(ec2RequestType);
                    var allMembers = TypeFactory.GetTypeInfo(typeof(AmazonEC2Client)).GetMembers();
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
                        var inputTypeInfo = TypeFactory.GetTypeInfo(inputType);
                        if (inputType == ec2RequestType || !ec2RequestTypeInfo.IsAssignableFrom(inputTypeInfo))
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
