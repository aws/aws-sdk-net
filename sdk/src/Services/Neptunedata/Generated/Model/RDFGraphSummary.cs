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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
        private List<string> _classes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _numClasses;
        private long? _numDistinctPredicates;
        private long? _numDistinctSubjects;
        private long? _numQuads;
        private List<Dictionary<string, long>> _predicates = AWSConfigs.InitializeCollections ? new List<Dictionary<string, long>>() : null;
        private List<SubjectStructure> _subjectStructures = AWSConfigs.InitializeCollections ? new List<SubjectStructure>() : null;

        /// <summary>
        /// Gets and sets the property Classes. 
        /// <para>
        /// A list of the classes in the graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Classes
        {
            get { return this._classes; }
            set { this._classes = value; }
        }

        // Check to see if Classes property is set
        internal bool IsSetClasses()
        {
            return this._classes != null && (this._classes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumClasses. 
        /// <para>
        /// The number of classes in the graph.
        /// </para>
        /// </summary>
        public long? NumClasses
        {
            get { return this._numClasses; }
            set { this._numClasses = value; }
        }

        // Check to see if NumClasses property is set
        internal bool IsSetNumClasses()
        {
            return this._numClasses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumDistinctPredicates. 
        /// <para>
        /// The number of distinct predicates in the graph.
        /// </para>
        /// </summary>
        public long? NumDistinctPredicates
        {
            get { return this._numDistinctPredicates; }
            set { this._numDistinctPredicates = value; }
        }

        // Check to see if NumDistinctPredicates property is set
        internal bool IsSetNumDistinctPredicates()
        {
            return this._numDistinctPredicates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumDistinctSubjects. 
        /// <para>
        /// The number of distinct subjects in the graph.
        /// </para>
        /// </summary>
        public long? NumDistinctSubjects
        {
            get { return this._numDistinctSubjects; }
            set { this._numDistinctSubjects = value; }
        }

        // Check to see if NumDistinctSubjects property is set
        internal bool IsSetNumDistinctSubjects()
        {
            return this._numDistinctSubjects.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumQuads. 
        /// <para>
        /// The number of quads in the graph.
        /// </para>
        /// </summary>
        public long? NumQuads
        {
            get { return this._numQuads; }
            set { this._numQuads = value; }
        }

        // Check to see if NumQuads property is set
        internal bool IsSetNumQuads()
        {
            return this._numQuads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Predicates. 
        /// <para>
        /// "A list of predicates in the graph, along with the predicate counts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, long>> Predicates
        {
            get { return this._predicates; }
            set { this._predicates = value; }
        }

        // Check to see if Predicates property is set
        internal bool IsSetPredicates()
        {
            return this._predicates != null && (this._predicates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubjectStructures. 
        /// <para>
        /// This field is only present when the request mode is <c>DETAILED</c>. It contains a
        /// list of subject structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubjectStructure> SubjectStructures
        {
            get { return this._subjectStructures; }
            set { this._subjectStructures = value; }
        }

        // Check to see if SubjectStructures property is set
        internal bool IsSetSubjectStructures()
        {
            return this._subjectStructures != null && (this._subjectStructures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}