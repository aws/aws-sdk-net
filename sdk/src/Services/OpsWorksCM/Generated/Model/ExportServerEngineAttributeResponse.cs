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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// This is the response object from the ExportServerEngineAttribute operation.
    /// </summary>
    public partial class ExportServerEngineAttributeResponse : AmazonWebServiceResponse
    {
        private EngineAttribute _engineAttribute;
        private string _serverName;

        /// <summary>
        /// Gets and sets the property EngineAttribute. 
        /// <para>
        /// The requested engine attribute pair with attribute name and value. 
        /// </para>
        /// </summary>
        public EngineAttribute EngineAttribute
        {
            get { return this._engineAttribute; }
            set { this._engineAttribute = value; }
        }

        // Check to see if EngineAttribute property is set
        internal bool IsSetEngineAttribute()
        {
            return this._engineAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The requested ServerName. 
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

    }
}