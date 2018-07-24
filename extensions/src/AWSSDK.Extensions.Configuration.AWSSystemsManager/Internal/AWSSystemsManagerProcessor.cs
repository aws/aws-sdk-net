﻿/*
 * Copyright 2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.Extensions.NETCore.Setup;
using Amazon.SimpleSystemsManagement;
using Amazon.SimpleSystemsManagement.Model;

namespace Amazon.Extensions.Configuration.AWSSystemsManager.Internal
{
    public interface IAWSSystemsManagerProcessor
    {
        Task<List<Parameter>> GetParametersByPath(AWSOptions awsOptions, string path);
    }

    public class AWSSystemsManagerProcessor : IAWSSystemsManagerProcessor
    {
        public async Task<List<Parameter>> GetParametersByPath(AWSOptions awsOptions, string path)
        {
            using (var client = awsOptions.CreateServiceClient<IAmazonSimpleSystemsManagement>())
            {
                var parameters = new List<Parameter>();
                string nextToken = null;
                do
                {
                    var response = await client.GetParametersByPathAsync(new GetParametersByPathRequest { Path = path, Recursive = true, WithDecryption = true, NextToken = nextToken });
                    nextToken = response.NextToken;
                    parameters.AddRange(response.Parameters);
                } while (nextToken != null);

                return parameters;
            }
        }
    }
}