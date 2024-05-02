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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A custom grouping of objects that include filters for prefixes, suffixes, object tags,
    /// object size, or object age. You can create an S3 Storage Lens group that includes
    /// a single filter or multiple filter conditions. To specify multiple filter conditions,
    /// you use <c>AND</c> or <c>OR</c> logical operators.
    /// </summary>
    public partial class StorageLensGroup
    {
        private StorageLensGroupFilter _filter;
        private string _name;
        private string _storageLensGroupArn;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Sets the criteria for the Storage Lens group data that is displayed. For multiple
        /// filter conditions, the <c>AND</c> or <c>OR</c> logical operator is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageLensGroupFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Contains the name of the Storage Lens group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property StorageLensGroupArn. 
        /// <para>
        ///  Contains the Amazon Resource Name (ARN) of the Storage Lens group. This property
        /// is read-only. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string StorageLensGroupArn
        {
            get { return this._storageLensGroupArn; }
            set { this._storageLensGroupArn = value; }
        }

        // Check to see if StorageLensGroupArn property is set
        internal bool IsSetStorageLensGroupArn()
        {
            return this._storageLensGroupArn != null;
        }

    }
}