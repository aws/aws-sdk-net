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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// The RDF graph summary API returns a read-only list of classes and predicate keys,
    /// along with counts of quads, subjects, and predicates.
    /// </summary>
    public partial class RDFGraphSummary
    {
        private List<string> _classes = new List<string>();
        private long? _numClasses;
        private long? _numDistinctPredicates;
        private long? _numDistinctSubjects;
        private long? _numQuads;
        private List<Dictionary<string, long>> _predicates = new List<Dictionary<string, long>>();
        private List<SubjectStructure> _subjectStructures = new List<SubjectStructure>();

        /// <summary>
        /// Gets and sets the property Classes. 
        /// <para>
        /// A list of the classes in the graph.
        /// </para>
        /// </summary>
        public List<string> Classes
        {
            get { return this._classes; }
            set { this._classes = value; }
        }

        // Check to see if Classes property is set
        internal bool IsSetClasses()
        {
            return this._classes != null && this._classes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NumClasses. 
        /// <para>
        /// The number of classes in the graph.
        /// </para>
        /// </summary>
        public long NumClasses
        {
            get { return this._numClasses.GetValueOrDefault(); }
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
        public long NumDistinctPredicates
        {
            get { return this._numDistinctPredicates.GetValueOrDefault(); }
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
        public long NumDistinctSubjects
        {
            get { return this._numDistinctSubjects.GetValueOrDefault(); }
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
        public long NumQuads
        {
            get { return this._numQuads.GetValueOrDefault(); }
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
        /// </summary>
        public List<Dictionary<string, long>> Predicates
        {
            get { return this._predicates; }
            set { this._predicates = value; }
        }

        // Check to see if Predicates property is set
        internal bool IsSetPredicates()
        {
            return this._predicates != null && this._predicates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubjectStructures. 
        /// <para>
        /// This field is only present when the request mode is <code>DETAILED</code>. It contains
        /// a list of subject structures.
        /// </para>
        /// </summary>
        public List<SubjectStructure> SubjectStructures
        {
            get { return this._subjectStructures; }
            set { this._subjectStructures = value; }
        }

        // Check to see if SubjectStructures property is set
        internal bool IsSetSubjectStructures()
        {
            return this._subjectStructures != null && this._subjectStructures.Count > 0; 
        }

    }
}