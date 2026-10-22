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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Criticality. 
        /// <para>
        /// The criticality classification of the dependency when the run started. A dependency
        /// that was not discovered has the UNKNOWN criticality.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DependencyCriticality Criticality { get; set; }

        /// <summary>
        /// Checks to see if the Criticality property is set.
        /// </summary>
        internal bool IsSetCriticality() => this.Criticality != null;

        /// <summary>
        /// Gets and sets the property DependencyId. 
        /// <para>
        /// The unique identifier of the dependency. Absent when the dependency was entered manually
        /// and was not part of dependency discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DependencyId { get; set; }

        /// <summary>
        /// Checks to see if the DependencyId property is set.
        /// </summary>
        internal bool IsSetDependencyId() => this.DependencyId != null;

        /// <summary>
        /// Gets and sets the property DependencyName. 
        /// <para>
        /// The name of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string DependencyName { get; set; }

        /// <summary>
        /// Checks to see if the DependencyName property is set.
        /// </summary>
        internal bool IsSetDependencyName() => this.DependencyName != null;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the dependency that the test run blocked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 253)]
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The origin of the dependency. A discovered dependency was found by dependency discovery;
        /// a manual dependency was entered when the run started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestRunDependencySource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceRegions. 
        /// <para>
        /// The source Regions from which the dependency was detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> SourceRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceRegions property is set.
        /// </summary>
        internal bool IsSetSourceRegions() => this.SourceRegions != null && (this.SourceRegions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
