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
    /// This is the response object from the DescribeLabelGroup operation.
    /// </summary>
    public partial class DescribeLabelGroupResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private List<string> _faultCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _labelGroupArn;
        private string _labelGroupName;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The time at which the label group was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaultCodes. 
        /// <para>
        ///  Codes indicating the type of anomaly associated with the labels in the lagbel group.
        /// 
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
        /// Gets and sets the property LabelGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LabelGroupArn
        {
            get { return this._labelGroupArn; }
            set { this._labelGroupArn = value; }
        }

        // Check to see if LabelGroupArn property is set
        internal bool IsSetLabelGroupArn()
        {
            return this._labelGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of the label group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The time at which the label group was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}