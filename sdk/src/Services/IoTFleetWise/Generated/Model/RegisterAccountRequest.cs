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
    /// Container for the parameters to the RegisterAccount operation.
    /// <important> 
    /// <para>
    /// This API operation contains deprecated parameters. Register your account again without
    /// the Timestream resources parameter so that Amazon Web Services IoT FleetWise can remove
    /// the Timestream metadata stored. You should then pass the data destination into the
    /// <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_CreateCampaign.html">CreateCampaign</a>
    /// API operation.
    /// </para>
    ///  
    /// <para>
    /// You must delete any existing campaigns that include an empty data destination before
    /// you register your account again. For more information, see the <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/APIReference/API_DeleteCampaign.html">DeleteCampaign</a>
    /// API operation.
    /// </para>
    ///  
    /// <para>
    /// If you want to delete the Timestream inline policy from the service-linked role, such
    /// as to mitigate an overly permissive policy, you must first delete any existing campaigns.
    /// Then delete the service-linked role and register your account again to enable CloudWatch
    /// metrics. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceLinkedRole.html">DeleteServiceLinkedRole</a>
    /// in the <i>Identity and Access Management API Reference</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// Registers your Amazon Web Services account, IAM, and Amazon Timestream resources so
    /// Amazon Web Services IoT FleetWise can transfer your vehicle data to the Amazon Web
    /// Services Cloud. For more information, including step-by-step procedures, see <a href="https://docs.aws.amazon.com/iot-fleetwise/latest/developerguide/setting-up.html">Setting
    /// up Amazon Web Services IoT FleetWise</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// An Amazon Web Services account is <b>not</b> the same thing as a "user." An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/introduction_identity-management.html#intro-identity-users">Amazon
    /// Web Services user</a> is an identity that you create using Identity and Access Management
    /// (IAM) and takes the form of either an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users.html">IAM
    /// user</a> or an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
    /// role, both with credentials</a>. A single Amazon Web Services account can, and typically
    /// does, contain many users and roles.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RegisterAccountRequest : AmazonIoTFleetWiseRequest
    {
        private IamResources _iamResources;
        private TimestreamResources _timestreamResources;

        /// <summary>
        /// Gets and sets the property IamResources. 
        /// <para>
        /// The IAM resource that allows Amazon Web Services IoT FleetWise to send data to Amazon
        /// Timestream.
        /// </para>
        /// </summary>
        [Obsolete("iamResources is no longer used or needed as input")]
        public IamResources IamResources
        {
            get { return this._iamResources; }
            set { this._iamResources = value; }
        }

        // Check to see if IamResources property is set
        internal bool IsSetIamResources()
        {
            return this._iamResources != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamResources.
        /// </summary>
        [Obsolete("Amazon Timestream metadata is now passed in the CreateCampaign API.")]
        public TimestreamResources TimestreamResources
        {
            get { return this._timestreamResources; }
            set { this._timestreamResources = value; }
        }

        // Check to see if TimestreamResources property is set
        internal bool IsSetTimestreamResources()
        {
            return this._timestreamResources != null;
        }

    }
}