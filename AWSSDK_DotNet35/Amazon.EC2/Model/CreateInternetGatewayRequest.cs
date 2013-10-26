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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInternetGateway operation.
    /// <para> Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to a VPC using
    /// <c>AttachInternetGateway</c> . For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
    /// </para>
    /// </summary>
    public partial class CreateInternetGatewayRequest : AmazonEC2Request
    {


    }
}
    
