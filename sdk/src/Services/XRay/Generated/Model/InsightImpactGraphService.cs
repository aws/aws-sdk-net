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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about an application that processed requests, users that made requests,
    /// or downstream services, resources, and applications that an application used.
    /// </summary>
    public partial class InsightImpactGraphService
    {
        private string _accountId;
        private List<InsightImpactGraphEdge> _edges = new List<InsightImpactGraphEdge>();
        private string _name;
        private List<string> _names = new List<string>();
        private int? _referenceId;
        private string _type;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Identifier of the AWS account in which the service runs.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// Connections to downstream services.
        /// </para>
        /// </summary>
        public List<InsightImpactGraphEdge> Edges
        {
            get { return this._edges; }
            set { this._edges = value; }
        }

        // Check to see if Edges property is set
        internal bool IsSetEdges()
        {
            return this._edges != null && this._edges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The canonical name of the service.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Names. 
        /// <para>
        /// A list of names for the service, including the canonical name.
        /// </para>
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && this._names.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
        /// </para>
        /// </summary>
        public int ReferenceId
        {
            get { return this._referenceId.GetValueOrDefault(); }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Identifier for the service. Unique within the service map.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Resource - The type of an AWS resource. For example, AWS::EC2::Instance for an
        /// application running on Amazon EC2 or AWS::DynamoDB::Table for an Amazon DynamoDB table
        /// that the application used. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Service - The type of an AWS service. For example, AWS::DynamoDB for downstream
        /// calls to Amazon DynamoDB that didn't target a specific table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Service - The type of an AWS service. For example, AWS::DynamoDB for downstream
        /// calls to Amazon DynamoDB that didn't target a specific table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// remote - A downstream service of indeterminate type.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}