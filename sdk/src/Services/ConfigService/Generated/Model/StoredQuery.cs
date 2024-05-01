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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the details of a stored query.
    /// </summary>
    public partial class StoredQuery
    {
        private string _description;
        private string _expression;
        private string _queryArn;
        private string _queryId;
        private string _queryName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A unique description for the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression of the query. For example, <c>SELECT resourceId, resourceType, supplementaryConfiguration.BucketVersioningConfiguration.status
        /// WHERE resourceType = 'AWS::S3::Bucket' AND supplementaryConfiguration.BucketVersioningConfiguration.status
        /// = 'Off'.</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property QueryArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the query. For example, arn:partition:service:region:account-id:resource-type/resource-name/resource-id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string QueryArn
        {
            get { return this._queryArn; }
            set { this._queryArn = value; }
        }

        // Check to see if QueryArn property is set
        internal bool IsSetQueryArn()
        {
            return this._queryArn != null;
        }

        /// <summary>
        /// Gets and sets the property QueryId. 
        /// <para>
        /// The ID of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string QueryId
        {
            get { return this._queryId; }
            set { this._queryId = value; }
        }

        // Check to see if QueryId property is set
        internal bool IsSetQueryId()
        {
            return this._queryId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryName. 
        /// <para>
        /// The name of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QueryName
        {
            get { return this._queryName; }
            set { this._queryName = value; }
        }

        // Check to see if QueryName property is set
        internal bool IsSetQueryName()
        {
            return this._queryName != null;
        }

    }
}