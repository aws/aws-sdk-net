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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the compare data sets step input.
    /// </summary>
    public partial class CompareDataSetsStepInput
    {
        private List<DataSet> _sourceDataSets = AWSConfigs.InitializeCollections ? new List<DataSet>() : null;
        private string _sourceLocation;
        private List<DataSet> _targetDataSets = AWSConfigs.InitializeCollections ? new List<DataSet>() : null;
        private string _targetLocation;

        /// <summary>
        /// Gets and sets the property SourceDataSets. 
        /// <para>
        /// The source data sets of the compare data sets step input location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataSet> SourceDataSets
        {
            get { return this._sourceDataSets; }
            set { this._sourceDataSets = value; }
        }

        // Check to see if SourceDataSets property is set
        internal bool IsSetSourceDataSets()
        {
            return this._sourceDataSets != null && (this._sourceDataSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The source location of the compare data sets step input location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDataSets. 
        /// <para>
        /// The target data sets of the compare data sets step input location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DataSet> TargetDataSets
        {
            get { return this._targetDataSets; }
            set { this._targetDataSets = value; }
        }

        // Check to see if TargetDataSets property is set
        internal bool IsSetTargetDataSets()
        {
            return this._targetDataSets != null && (this._targetDataSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetLocation. 
        /// <para>
        /// The target location of the compare data sets step input location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string TargetLocation
        {
            get { return this._targetLocation; }
            set { this._targetLocation = value; }
        }

        // Check to see if TargetLocation property is set
        internal bool IsSetTargetLocation()
        {
            return this._targetLocation != null;
        }

    }
}