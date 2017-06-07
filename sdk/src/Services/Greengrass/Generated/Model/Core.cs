/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Information on the core
    /// </summary>
    public partial class Core
    {
        private string _certificateArn;
        private string _id;
        private bool? _syncShadow;
        private string _thingArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. Certificate arn of the core.
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. Element Id for this entry in the list.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SyncShadow. If true, the local shadow value automatically
        /// syncs with the cloud's shadow state.
        /// </summary>
        public bool SyncShadow
        {
            get { return this._syncShadow.GetValueOrDefault(); }
            set { this._syncShadow = value; }
        }

        // Check to see if SyncShadow property is set
        internal bool IsSetSyncShadow()
        {
            return this._syncShadow.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThingArn. Thing arn of the core.
        /// </summary>
        public string ThingArn
        {
            get { return this._thingArn; }
            set { this._thingArn = value; }
        }

        // Check to see if ThingArn property is set
        internal bool IsSetThingArn()
        {
            return this._thingArn != null;
        }

    }
}