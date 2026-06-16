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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// This is the response object from the UpdateDependency operation.
    /// </summary>
    public partial class UpdateDependencyResponse : AmazonWebServiceResponse
    {
        private string _comment;
        private DependencyCriticality _criticality;
        private string _dependencyId;
        private string _dependencyName;
        private string _location;
        private string _provider;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The comment about the dependency.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The criticality level of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DependencyCriticality Criticality
        {
            get { return this._criticality; }
            set { this._criticality = value; }
        }

        // Check to see if Criticality property is set
        internal bool IsSetCriticality()
        {
            return this._criticality != null;
        }

        /// <summary>
        /// Gets and sets the property DependencyId. 
        /// <para>
        /// The identifier of the updated dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DependencyId
        {
            get { return this._dependencyId; }
            set { this._dependencyId = value; }
        }

        // Check to see if DependencyId property is set
        internal bool IsSetDependencyId()
        {
            return this._dependencyId != null;
        }

        /// <summary>
        /// Gets and sets the property DependencyName. 
        /// <para>
        /// The name of the updated dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DependencyName
        {
            get { return this._dependencyName; }
            set { this._dependencyName = value; }
        }

        // Check to see if DependencyName property is set
        internal bool IsSetDependencyName()
        {
            return this._dependencyName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the dependency.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the dependency was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}