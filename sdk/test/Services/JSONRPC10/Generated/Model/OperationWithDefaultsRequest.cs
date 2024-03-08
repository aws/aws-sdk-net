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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.JSONRPC10.Model
{
    /// <summary>
    /// Container for the parameters to the OperationWithDefaults operation.
    /// 
    /// </summary>
    public partial class OperationWithDefaultsRequest : AmazonJSONRPC10Request
    {
        private ClientOptionalDefaults _clientOptionalDefaults;
        private Defaults _defaults;
        private int? _otherTopLevelDefault;
        private string _topLevelDefault;

        /// <summary>
        /// Gets and sets the property ClientOptionalDefaults.
        /// </summary>
        public ClientOptionalDefaults ClientOptionalDefaults
        {
            get { return this._clientOptionalDefaults; }
            set { this._clientOptionalDefaults = value; }
        }

        // Check to see if ClientOptionalDefaults property is set
        internal bool IsSetClientOptionalDefaults()
        {
            return this._clientOptionalDefaults != null;
        }

        /// <summary>
        /// Gets and sets the property Defaults.
        /// </summary>
        public Defaults Defaults
        {
            get { return this._defaults; }
            set { this._defaults = value; }
        }

        // Check to see if Defaults property is set
        internal bool IsSetDefaults()
        {
            return this._defaults != null;
        }

        /// <summary>
        /// Gets and sets the property OtherTopLevelDefault.
        /// </summary>
        public int OtherTopLevelDefault
        {
            get { return this._otherTopLevelDefault.GetValueOrDefault(); }
            set { this._otherTopLevelDefault = value; }
        }

        // Check to see if OtherTopLevelDefault property is set
        internal bool IsSetOtherTopLevelDefault()
        {
            return this._otherTopLevelDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopLevelDefault.
        /// </summary>
        public string TopLevelDefault
        {
            get { return this._topLevelDefault; }
            set { this._topLevelDefault = value; }
        }

        // Check to see if TopLevelDefault property is set
        internal bool IsSetTopLevelDefault()
        {
            return this._topLevelDefault != null;
        }

    }
}