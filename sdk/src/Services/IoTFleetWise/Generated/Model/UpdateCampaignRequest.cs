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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCampaign operation.
    /// Updates a campaign.
    /// </summary>
    public partial class UpdateCampaignRequest : AmazonIoTFleetWiseRequest
    {
        private UpdateCampaignAction _action;
        private List<string> _dataExtraDimensions = new List<string>();
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        ///  Specifies how to update a campaign. The action can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>APPROVE</code> - To approve delivering a data collection scheme to vehicles.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUSPEND</code> - To suspend collecting signal data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESUME</code> - To resume collecting signal data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE</code> - To update a campaign. 
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
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> DataExtraDimensions
        {
            get { return this._dataExtraDimensions; }
            set { this._dataExtraDimensions = value; }
        }

        // Check to see if DataExtraDimensions property is set
        internal bool IsSetDataExtraDimensions()
        {
            return this._dataExtraDimensions != null && this._dataExtraDimensions.Count > 0; 
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