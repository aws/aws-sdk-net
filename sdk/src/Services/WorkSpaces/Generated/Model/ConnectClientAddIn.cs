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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes an Amazon Connect client add-in.
    /// </summary>
    public partial class ConnectClientAddIn
    {
        private string _addInId;
        private string _name;
        private string _resourceId;
        private string _url;

        /// <summary>
        /// Gets and sets the property AddInId. 
        /// <para>
        /// The client add-in identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AddInId
        {
            get { return this._addInId; }
            set { this._addInId = value; }
        }

        // Check to see if AddInId property is set
        internal bool IsSetAddInId()
        {
            return this._addInId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the client add in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The directory identifier for which the client add-in is configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=65)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property URL. 
        /// <para>
        /// The endpoint URL of the client add-in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string URL
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if URL property is set
        internal bool IsSetURL()
        {
            return this._url != null;
        }

    }
}