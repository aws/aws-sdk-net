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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListCommands operation.
    /// List all commands in your account.
    /// </summary>
    public partial class ListCommandsRequest : AmazonIoTRequest
    {
        private string _commandParameterName;
        private int? _maxResults;
        private CommandNamespace _awsNamespace;
        private string _nextToken;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CommandParameterName. 
        /// <para>
        /// A filter that can be used to display the list of commands that have a specific command
        /// parameter name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=192)]
        public string CommandParameterName
        {
            get { return this._commandParameterName; }
            set { this._commandParameterName = value; }
        }

        // Check to see if CommandParameterName property is set
        internal bool IsSetCommandParameterName()
        {
            return this._commandParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation. By default, the API returns
        /// up to a maximum of 25 results. You can override this default value to return up to
        /// a maximum of 100 results for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the command. By default, the API returns all commands that have been
        /// created for both <c>AWS-IoT</c> and <c>AWS-IoT-FleetWise</c> namespaces. You can override
        /// this default value if you want to return all commands that have been created only
        /// for a specific namespace.
        /// </para>
        /// </summary>
        public CommandNamespace Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <c>nextToken</c> value from a previous response;
        /// otherwise <c>null</c> to receive the first set of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Specify whether to list the commands that you have created in the ascending or descending
        /// order. By default, the API returns all commands in the descending order based on the
        /// time that they were created.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}