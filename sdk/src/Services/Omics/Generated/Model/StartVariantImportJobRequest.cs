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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the StartVariantImportJob operation.
    /// Starts a variant import job.
    /// </summary>
    public partial class StartVariantImportJobRequest : AmazonOmicsRequest
    {
        private string _destinationName;
        private List<VariantImportItemSource> _items = new List<VariantImportItemSource>();
        private string _roleArn;
        private bool? _runLeftNormalization;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The destination variant store for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Items to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<VariantImportItemSource> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A service role for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunLeftNormalization. 
        /// <para>
        /// The job's left normalization setting.
        /// </para>
        /// </summary>
        public bool RunLeftNormalization
        {
            get { return this._runLeftNormalization.GetValueOrDefault(); }
            set { this._runLeftNormalization = value; }
        }

        // Check to see if RunLeftNormalization property is set
        internal bool IsSetRunLeftNormalization()
        {
            return this._runLeftNormalization.HasValue; 
        }

    }
}