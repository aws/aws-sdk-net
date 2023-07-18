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

namespace Amazon.Util
{
    public abstract class EnvironmentVariables
    {
        public const string AWS_LAMBDA_FUNCTION_NAME = "AWS_LAMBDA_FUNCTION_NAME";
        public const string _X_AMZN_TRACE_ID = "_X_AMZN_TRACE_ID";
        public const string SERVICE_SPECIFIC_ENDPOINT_ENVIRONMENT_VARIABLE_PREFIX = "AWS_ENDPOINT_URL_";
        public const string GLOBAL_ENDPOINT_ENVIRONMENT_VARIABLE = "AWS_ENDPOINT_URL";
    }
}
