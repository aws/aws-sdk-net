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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The collection of components that defines the time-series.
    /// </summary>
    public partial class TimeSeriesConfig
    {
        private List<string> _groupingAttributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _itemIdentifierAttributeName;
        private string _targetAttributeName;
        private string _timestampAttributeName;

        /// <summary>
        /// Gets and sets the property GroupingAttributeNames. 
        /// <para>
        /// A set of columns names that can be grouped with the item identifier column to create
        /// a composite key for which a target value is predicted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> GroupingAttributeNames
        {
            get { return this._groupingAttributeNames; }
            set { this._groupingAttributeNames = value; }
        }

        // Check to see if GroupingAttributeNames property is set
        internal bool IsSetGroupingAttributeNames()
        {
            return this._groupingAttributeNames != null && (this._groupingAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ItemIdentifierAttributeName. 
        /// <para>
        /// The name of the column that represents the set of item identifiers for which you want
        /// to predict the target value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ItemIdentifierAttributeName
        {
            get { return this._itemIdentifierAttributeName; }
            set { this._itemIdentifierAttributeName = value; }
        }

        // Check to see if ItemIdentifierAttributeName property is set
        internal bool IsSetItemIdentifierAttributeName()
        {
            return this._itemIdentifierAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAttributeName. 
        /// <para>
        /// The name of the column representing the target variable that you want to predict for
        /// each item in your dataset. The data type of the target variable must be numerical.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string TargetAttributeName
        {
            get { return this._targetAttributeName; }
            set { this._targetAttributeName = value; }
        }

        // Check to see if TargetAttributeName property is set
        internal bool IsSetTargetAttributeName()
        {
            return this._targetAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampAttributeName. 
        /// <para>
        /// The name of the column indicating a point in time at which the target value of a given
        /// item is recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TimestampAttributeName
        {
            get { return this._timestampAttributeName; }
            set { this._timestampAttributeName = value; }
        }

        // Check to see if TimestampAttributeName property is set
        internal bool IsSetTimestampAttributeName()
        {
            return this._timestampAttributeName != null;
        }

    }
}