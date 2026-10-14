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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Contains options for configuring X12 acknowledgments. These options control how functional
    /// and technical acknowledgments are handled.
    /// </summary>
    public partial class X12AcknowledgmentOptions
    {
        /// <summary>
        /// Gets and sets the property FunctionalAcknowledgment. 
        /// <para>
        /// Specifies whether functional acknowledgments (997/999) should be generated for incoming
        /// X12 transactions. Valid values are <c>DO_NOT_GENERATE</c>, <c>GENERATE_ALL_SEGMENTS</c>
        /// and <c>GENERATE_WITHOUT_TRANSACTION_SET_RESPONSE_LOOP</c>.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>GENERATE_WITHOUT_TRANSACTION_SET_RESPONSE_LOOP</c>, Amazon Web Services
        /// B2B Data Interchange skips the AK2_Loop when generating an acknowledgment document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public X12FunctionalAcknowledgment FunctionalAcknowledgment { get; set; }

        /// <summary>
        /// Checks to see if the FunctionalAcknowledgment property is set.
        /// </summary>
        internal bool IsSetFunctionalAcknowledgment() => this.FunctionalAcknowledgment != null;

        /// <summary>
        /// Gets and sets the property TechnicalAcknowledgment. 
        /// <para>
        /// Specifies whether technical acknowledgments (TA1) should be generated for incoming
        /// X12 interchanges. Valid values are <c>DO_NOT_GENERATE</c> and <c>GENERATE_ALL_SEGMENTS</c>
        /// and.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public X12TechnicalAcknowledgment TechnicalAcknowledgment { get; set; }

        /// <summary>
        /// Checks to see if the TechnicalAcknowledgment property is set.
        /// </summary>
        internal bool IsSetTechnicalAcknowledgment() => this.TechnicalAcknowledgment != null;
    }
}
