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
    /// Container for the parameters to the CreateConnectClientAddIn operation.
    /// Creates a client-add-in for Amazon Connect within a directory. You can create only
    /// one Amazon Connect client add-in within a directory.
    /// 
    ///  
    /// <para>
    /// This client add-in allows WorkSpaces users to seamlessly connect to Amazon Connect.
    /// </para>
    /// </summary>
    public partial class CreateConnectClientAddInRequest : AmazonWorkSpacesRequest
    {
        private string _name;
        private string _resourceId;
        private string _url;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the client add-in.
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The directory identifier for which to configure the client add-in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
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
        /// The endpoint URL of the Amazon Connect client add-in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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