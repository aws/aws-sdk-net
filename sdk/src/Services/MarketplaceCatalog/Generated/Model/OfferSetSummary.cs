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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Summarized information about an offer set.
    /// </summary>
    public partial class OfferSetSummary
    {
        private List<string> _associatedOfferIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _releaseDate;
        private string _solutionId;
        private OfferSetStateString _state;

        /// <summary>
        /// Gets and sets the property AssociatedOfferIds. 
        /// <para>
        /// The list of offer IDs associated with the offer set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> AssociatedOfferIds
        {
            get { return this._associatedOfferIds; }
            set { this._associatedOfferIds = value; }
        }

        // Check to see if AssociatedOfferIds property is set
        internal bool IsSetAssociatedOfferIds()
        {
            return this._associatedOfferIds != null && (this._associatedOfferIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
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
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The release date of the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionId. 
        /// <para>
        /// The solution ID associated with the offer set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string SolutionId
        {
            get { return this._solutionId; }
            set { this._solutionId = value; }
        }

        // Check to see if SolutionId property is set
        internal bool IsSetSolutionId()
        {
            return this._solutionId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the offer set.
        /// </para>
        /// </summary>
        public OfferSetStateString State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}