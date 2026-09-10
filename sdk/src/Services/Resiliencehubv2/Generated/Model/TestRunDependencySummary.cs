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
    /// Contains summary information about a dependency that a test run blocked, as captured
    /// when the run started.
    /// </summary>
    public partial class TestRunDependencySummary
    {
        private DependencyCriticality _criticality;
        private string _dependencyId;
        private string _dependencyName;
        private string _dnsName;
        private string _location;
        private string _provider;
        private TestRunDependencySource _source;
        private List<string> _sourceRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The criticality classification of the dependency when the run started. A dependency
        /// that was not discovered has the UNKNOWN criticality.
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
        /// The unique identifier of the dependency. Absent when the dependency was entered manually
        /// and was not part of dependency discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The name of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the dependency that the test run blocked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The origin of the dependency. A discovered dependency was found by dependency discovery;
        /// a manual dependency was entered when the run started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestRunDependencySource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegions. 
        /// <para>
        /// The source Regions from which the dependency was detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> SourceRegions
        {
            get { return this._sourceRegions; }
            set { this._sourceRegions = value; }
        }

        // Check to see if SourceRegions property is set
        internal bool IsSetSourceRegions()
        {
            return this._sourceRegions != null && (this._sourceRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}