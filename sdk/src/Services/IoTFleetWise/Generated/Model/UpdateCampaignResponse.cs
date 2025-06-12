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
    /// This is the response object from the UpdateCampaign operation.
    /// </summary>
    public partial class UpdateCampaignResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _name;
        private CampaignStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the campaign. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the updated campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of a campaign. The status can be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - Amazon Web Services IoT FleetWise is processing your request to
        /// create the campaign. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WAITING_FOR_APPROVAL</c> - After you create a campaign, it enters this state.
        /// Use the API operation to approve the campaign for deployment to the target vehicle
        /// or fleet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> - The campaign is active. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c> - The campaign is suspended. To resume the campaign, use the API
        /// operation. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CampaignStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}