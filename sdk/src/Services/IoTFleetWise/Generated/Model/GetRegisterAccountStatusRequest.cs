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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the GetRegisterAccountStatus operation.
    /// Retrieves information about the status of registering your Amazon Web Services account,
    /// IAM, and Amazon Timestream resources so that Amazon Web Services IoT FleetWise can
    /// transfer your vehicle data to the Amazon Web Services Cloud. 
    /// 
    ///  
    /// <para>
    /// For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
    /// up Amazon Web Services IoT FleetWise</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// This API operation doesn't require input parameters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetRegisterAccountStatusRequest : AmazonIoTFleetWiseRequest
    {

    }
}