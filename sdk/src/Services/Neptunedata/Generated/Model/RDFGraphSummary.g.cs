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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// The RDF graph summary API returns a read-only list of classes and predicate keys,
    /// along with counts of quads, subjects, and predicates.
    /// </summary>
    public partial class RDFGraphSummary
    {
        /// <summary>
        /// Gets and sets the property Classes. 
        /// <para>
        /// A list of the classes in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Classes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Classes property is set.
        /// </summary>
        internal bool IsSetClasses() => this.Classes != null && (this.Classes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumClasses. 
        /// <para>
        /// The number of classes in the graph.
        /// </para>
        /// </summary>
        public long? NumClasses { get; set; }

        /// <summary>
        /// Checks to see if the NumClasses property is set.
        /// </summary>
        internal bool IsSetNumClasses() => this.NumClasses.HasValue;

        /// <summary>
        /// Gets and sets the property NumDistinctPredicates. 
        /// <para>
        /// The number of distinct predicates in the graph.
        /// </para>
        /// </summary>
        public long? NumDistinctPredicates { get; set; }

        /// <summary>
        /// Checks to see if the NumDistinctPredicates property is set.
        /// </summary>
        internal bool IsSetNumDistinctPredicates() => this.NumDistinctPredicates.HasValue;

        /// <summary>
        /// Gets and sets the property NumDistinctSubjects. 
        /// <para>
        /// The number of distinct subjects in the graph.
        /// </para>
        /// </summary>
        public long? NumDistinctSubjects { get; set; }

        /// <summary>
        /// Checks to see if the NumDistinctSubjects property is set.
        /// </summary>
        internal bool IsSetNumDistinctSubjects() => this.NumDistinctSubjects.HasValue;

        /// <summary>
        /// Gets and sets the property NumQuads. 
        /// <para>
        /// The number of quads in the graph.
        /// </para>
        /// </summary>
        public long? NumQuads { get; set; }

        /// <summary>
        /// Checks to see if the NumQuads property is set.
        /// </summary>
        internal bool IsSetNumQuads() => this.NumQuads.HasValue;

        /// <summary>
        /// Gets and sets the property Predicates. 
        /// <para>
        /// "A list of predicates in the graph, along with the predicate counts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> Predicates { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;

        /// <summary>
        /// Checks to see if the Predicates property is set.
        /// </summary>
        internal bool IsSetPredicates() => this.Predicates != null && (this.Predicates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubjectStructures. 
        /// <para>
        /// This field is only present when the request mode is <c>DETAILED</c>. It contains a
        /// list of subject structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubjectStructure> SubjectStructures { get; set; } = AWSConfigs.InitializeCollections ? new List<SubjectStructure>() : null;

        /// <summary>
        /// Checks to see if the SubjectStructures property is set.
        /// </summary>
        internal bool IsSetSubjectStructures() => this.SubjectStructures != null && (this.SubjectStructures.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
