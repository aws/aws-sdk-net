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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A filter for fields. Only one value can be provided.
    /// </summary>
    public partial class FieldFilter
    {
        private FieldValue _contains;
        private FieldValue _equalTo;
        private FieldValue _greaterThan;
        private FieldValue _greaterThanOrEqualTo;
        private FieldValue _lessThan;
        private FieldValue _lessThanOrEqualTo;

        /// <summary>
        /// Gets and sets the property Contains. 
        /// <para>
        /// Object containing field identifier and value information.
        /// </para>
        /// </summary>
        public FieldValue Contains
        {
            get { return this._contains; }
            set { this._contains = value; }
        }

        // Check to see if Contains property is set
        internal bool IsSetContains()
        {
            return this._contains != null;
        }

        /// <summary>
        /// Gets and sets the property EqualTo. 
        /// <para>
        /// Object containing field identifier and value information.
        /// </para>
        /// </summary>
        public FieldValue EqualTo
        {
            get { return this._equalTo; }
            set { this._equalTo = value; }
        }

        // Check to see if EqualTo property is set
        internal bool IsSetEqualTo()
        {
            return this._equalTo != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Object containing field identifier and value information.
        /// </para>
        /// </summary>
        public FieldValue GreaterThan
        {
            get { return this._greaterThan; }
            set { this._greaterThan = value; }
        }

        // Check to see if GreaterThan property is set
        internal bool IsSetGreaterThan()
        {
            return this._greaterThan != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThanOrEqualTo. 
        /// <para>
        /// Object containing field identifier and value information.
        /// </para>
        /// </summary>
        public FieldValue GreaterThanOrEqualTo
        {
            get { return this._greaterThanOrEqualTo; }
            set { this._greaterThanOrEqualTo = value; }
        }

        // Check to see if GreaterThanOrEqualTo property is set
        internal bool IsSetGreaterThanOrEqualTo()
        {
            return this._greaterThanOrEqualTo != null;
        }

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Object containing field identifier and value information.
        /// </para>
        /// </summary>
        public FieldValue LessThan
        {
            get { return this._lessThan; }
            set { this._lessThan = value; }
        }

        // Check to see if LessThan property is set
        internal bool IsSetLessThan()
        {
            return this._lessThan != null;
        }

        /// <summary>
        /// Gets and sets the property LessThanOrEqualTo. 
        /// <para>
        /// Object containing field identifier and value information. 
        /// </para>
        /// </summary>
        public FieldValue LessThanOrEqualTo
        {
            get { return this._lessThanOrEqualTo; }
            set { this._lessThanOrEqualTo = value; }
        }

        // Check to see if LessThanOrEqualTo property is set
        internal bool IsSetLessThanOrEqualTo()
        {
            return this._lessThanOrEqualTo != null;
        }

    }
}