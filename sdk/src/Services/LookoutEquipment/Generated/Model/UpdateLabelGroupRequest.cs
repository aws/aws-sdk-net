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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLabelGroup operation.
    /// Updates the label group.
    /// </summary>
    public partial class UpdateLabelGroupRequest : AmazonLookoutEquipmentRequest
    {
        private List<string> _faultCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _labelGroupName;

        /// <summary>
        /// Gets and sets the property FaultCodes. 
        /// <para>
        ///  Updates the code indicating the type of anomaly associated with the label. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> FaultCodes
        {
            get { return this._faultCodes; }
            set { this._faultCodes = value; }
        }

        // Check to see if FaultCodes property is set
        internal bool IsSetFaultCodes()
        {
            return this._faultCodes != null && (this._faultCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of the label group to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string LabelGroupName
        {
            get { return this._labelGroupName; }
            set { this._labelGroupName = value; }
        }

        // Check to see if LabelGroupName property is set
        internal bool IsSetLabelGroupName()
        {
            return this._labelGroupName != null;
        }

    }
}