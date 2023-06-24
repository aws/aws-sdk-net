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

/*
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateServiceRoleFromAccount operation.
    /// Disassociates the Greengrass service role from IoT Greengrass for your Amazon Web
    /// Services account in this Amazon Web Services Region. Without a service role, IoT Greengrass
    /// can't verify the identity of client devices or manage core device connectivity information.
    /// For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-service-role.html">Greengrass
    /// service role</a> in the <i>IoT Greengrass Version 2 Developer Guide</i>.
    /// </summary>
    public partial class DisassociateServiceRoleFromAccountRequest : AmazonGreengrassV2Request
    {

    }
}