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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNamedQuery operation.
    /// Updates a <a>NamedQuery</a> object. The database or workgroup cannot be updated.
    /// </summary>
    public partial class UpdateNamedQueryRequest : AmazonAthenaRequest
    {
        private string _description;
        private string _name;
        private string _namedQueryId;
        private string _queryString;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The query description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property NamedQueryId. 
        /// <para>
        /// The unique identifier (UUID) of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NamedQueryId
        {
            get { return this._namedQueryId; }
            set { this._namedQueryId = value; }
        }

        // Check to see if NamedQueryId property is set
        internal bool IsSetNamedQueryId()
        {
            return this._namedQueryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The contents of the query with all query statements.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

    }
}