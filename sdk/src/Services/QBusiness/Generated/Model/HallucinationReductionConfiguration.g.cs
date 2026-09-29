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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration information required to setup hallucination reduction. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/hallucination-reduction.html">
    /// hallucination reduction</a>.
    /// 
    ///  <note> 
    /// <para>
    /// The hallucination reduction feature won't work if chat orchestration controls are
    /// enabled for your application.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class HallucinationReductionConfiguration
    {
        /// <summary>
        /// Gets and sets the property HallucinationReductionControl. 
        /// <para>
        /// Controls whether hallucination reduction has been enabled or disabled for your application.
        /// The default status is <c>DISABLED</c>. 
        /// </para>
        /// </summary>
        public HallucinationReductionControl HallucinationReductionControl { get; set; }

        /// <summary>
        /// Checks to see if the HallucinationReductionControl property is set.
        /// </summary>
        internal bool IsSetHallucinationReductionControl() => this.HallucinationReductionControl != null;
    }
}
