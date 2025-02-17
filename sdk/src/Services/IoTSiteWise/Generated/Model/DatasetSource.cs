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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// The data source for the dataset.
    /// </summary>
    public partial class DatasetSource
    {
        private SourceDetail _sourceDetail;
        private DatasetSourceFormat _sourceFormat;
        private DatasetSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property SourceDetail. 
        /// <para>
        /// The details of the dataset source associated with the dataset.
        /// </para>
        /// </summary>
        public SourceDetail SourceDetail
        {
            get { return this._sourceDetail; }
            set { this._sourceDetail = value; }
        }

        // Check to see if SourceDetail property is set
        internal bool IsSetSourceDetail()
        {
            return this._sourceDetail != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The format of the dataset source associated with the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSourceFormat SourceFormat
        {
            get { return this._sourceFormat; }
            set { this._sourceFormat = value; }
        }

        // Check to see if SourceFormat property is set
        internal bool IsSetSourceFormat()
        {
            return this._sourceFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of data source for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}