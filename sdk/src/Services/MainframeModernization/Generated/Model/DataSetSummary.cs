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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// A subset of the possible data set attributes.
    /// </summary>
    public partial class DataSetSummary
    {
        private DateTime? _creationTime;
        private string _dataSetName;
        private string _dataSetOrg;
        private string _format;
        private DateTime? _lastReferencedTime;
        private DateTime? _lastUpdatedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the data set was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetName. 
        /// <para>
        /// The name of the data set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetName
        {
            get { return this._dataSetName; }
            set { this._dataSetName = value; }
        }

        // Check to see if DataSetName property is set
        internal bool IsSetDataSetName()
        {
            return this._dataSetName != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetOrg. 
        /// <para>
        /// The type of data set. The only supported value is VSAM.
        /// </para>
        /// </summary>
        public string DataSetOrg
        {
            get { return this._dataSetOrg; }
            set { this._dataSetOrg = value; }
        }

        // Check to see if DataSetOrg property is set
        internal bool IsSetDataSetOrg()
        {
            return this._dataSetOrg != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the data set. 
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property LastReferencedTime. 
        /// <para>
        /// The last time the data set was referenced.
        /// </para>
        /// </summary>
        public DateTime LastReferencedTime
        {
            get { return this._lastReferencedTime.GetValueOrDefault(); }
            set { this._lastReferencedTime = value; }
        }

        // Check to see if LastReferencedTime property is set
        internal bool IsSetLastReferencedTime()
        {
            return this._lastReferencedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last time the data set was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

    }
}