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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information on boosting <c>NUMBER</c> type document attributes.
    /// 
    ///  
    /// <para>
    /// For more information on how boosting document attributes work in Amazon Q Business,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/metadata-boosting.html">Boosting
    /// using document attributes</a>.
    /// </para>
    /// </summary>
    public partial class NumberAttributeBoostingConfiguration
    {
        private DocumentAttributeBoostingLevel _boostingLevel;
        private NumberAttributeBoostingType _boostingType;

        /// <summary>
        /// Gets and sets the property BoostingLevel. 
        /// <para>
        /// Specifies the duration, in seconds, of a boost applies to a <c>NUMBER</c> type document
        /// attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentAttributeBoostingLevel BoostingLevel
        {
            get { return this._boostingLevel; }
            set { this._boostingLevel = value; }
        }

        // Check to see if BoostingLevel property is set
        internal bool IsSetBoostingLevel()
        {
            return this._boostingLevel != null;
        }

        /// <summary>
        /// Gets and sets the property BoostingType. 
        /// <para>
        /// Specifies how much a document attribute is boosted.
        /// </para>
        /// </summary>
        public NumberAttributeBoostingType BoostingType
        {
            get { return this._boostingType; }
            set { this._boostingType = value; }
        }

        // Check to see if BoostingType property is set
        internal bool IsSetBoostingType()
        {
            return this._boostingType != null;
        }

    }
}