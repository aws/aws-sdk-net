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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the privacy constraints inherited from parent tables for an intermediate
    /// table version.
    /// </summary>
    public partial class IntermediateTableInheritedConstraints
    {
        private InheritedAdditionalAnalyses _additionalAnalyses;
        private InheritedAllowedAdditionalAnalyses _allowedAdditionalAnalyses;
        private InheritedAllowedResultReceivers _allowedResultReceivers;
        private InheritedDisallowedOutputColumns _disallowedOutputColumns;

        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        /// The inherited additional analyses constraint.
        /// </para>
        /// </summary>
        public InheritedAdditionalAnalyses AdditionalAnalyses
        {
            get { return this._additionalAnalyses; }
            set { this._additionalAnalyses = value; }
        }

        // Check to see if AdditionalAnalyses property is set
        internal bool IsSetAdditionalAnalyses()
        {
            return this._additionalAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedAdditionalAnalyses. 
        /// <para>
        /// The inherited allowed additional analyses constraint.
        /// </para>
        /// </summary>
        public InheritedAllowedAdditionalAnalyses AllowedAdditionalAnalyses
        {
            get { return this._allowedAdditionalAnalyses; }
            set { this._allowedAdditionalAnalyses = value; }
        }

        // Check to see if AllowedAdditionalAnalyses property is set
        internal bool IsSetAllowedAdditionalAnalyses()
        {
            return this._allowedAdditionalAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedResultReceivers. 
        /// <para>
        /// The inherited allowed result receivers constraint.
        /// </para>
        /// </summary>
        public InheritedAllowedResultReceivers AllowedResultReceivers
        {
            get { return this._allowedResultReceivers; }
            set { this._allowedResultReceivers = value; }
        }

        // Check to see if AllowedResultReceivers property is set
        internal bool IsSetAllowedResultReceivers()
        {
            return this._allowedResultReceivers != null;
        }

        /// <summary>
        /// Gets and sets the property DisallowedOutputColumns. 
        /// <para>
        /// The inherited disallowed output columns constraint.
        /// </para>
        /// </summary>
        public InheritedDisallowedOutputColumns DisallowedOutputColumns
        {
            get { return this._disallowedOutputColumns; }
            set { this._disallowedOutputColumns = value; }
        }

        // Check to see if DisallowedOutputColumns property is set
        internal bool IsSetDisallowedOutputColumns()
        {
            return this._disallowedOutputColumns != null;
        }

    }
}