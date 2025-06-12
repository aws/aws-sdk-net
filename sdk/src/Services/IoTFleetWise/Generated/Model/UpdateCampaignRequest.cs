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
    /// Container for the parameters to the UpdateCampaign operation.
    /// Updates a campaign.
    /// </summary>
    public partial class UpdateCampaignRequest : AmazonIoTFleetWiseRequest
    {
        private UpdateCampaignAction _action;
        private List<string> _dataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  Specifies how to update a campaign. The action can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPROVE</c> - To approve delivering a data collection scheme to vehicles. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPEND</c> - To suspend collecting signal data. The campaign is deleted from
        /// vehicles and all vehicles in the suspended campaign will stop sending data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESUME</c> - To reactivate the <c>SUSPEND</c> campaign. The campaign is redeployed
        /// to all vehicles and the vehicles will resume sending data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE</c> - To update a campaign. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateCampaignAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        ///  A list of vehicle attributes to associate with a signal. 
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=5)]
        public List<string> DataExtraDimensions
        {
            get { return this._dataExtraDimensions; }
            set { this._dataExtraDimensions = value; }
        }

        // Check to see if DataExtraDimensions property is set
        internal bool IsSetDataExtraDimensions()
        {
            return this._dataExtraDimensions != null && (this._dataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the campaign to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}