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
    /// Each entry contains a Storage Lens group that exists in the specified home Region.
    /// </summary>
    public partial class ListStorageLensGroupEntry
    {
        private string _homeRegion;
        private string _name;
        private string _storageLensGroupArn;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        ///  Contains the Amazon Web Services Region where the Storage Lens group was created.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=30)]
        public string HomeRegion
        {
            get { return this._homeRegion; }
            set { this._homeRegion = value; }
        }

        // Check to see if HomeRegion property is set
        internal bool IsSetHomeRegion()
        {
            return this._homeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Contains the name of the Storage Lens group that exists in the specified home Region.
        /// 
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
        [AWSProperty(Required=true, Min=4, Max=1024)]
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