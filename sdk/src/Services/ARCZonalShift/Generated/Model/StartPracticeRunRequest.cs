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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the StartPracticeRun operation.
    /// Start an on-demand practice run zonal shift in Amazon Application Recovery Controller.
    /// With zonal autoshift enabled, you can start an on-demand practice run to verify preparedness
    /// at any time. Amazon Web Services also runs automated practice runs about weekly when
    /// you have enabled zonal autoshift.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.considerations.html">
    /// Considerations when you configure zonal autoshift</a> in the Amazon Application Recovery
    /// Controller Developer Guide.
    /// </para>
    /// </summary>
    public partial class StartPracticeRunRequest : AmazonARCZonalShiftRequest
    {
        private string _awayFrom;
        private string _comment;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic is shifted away
        /// from for the resource that you specify for the practice run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public string AwayFrom
        {
            get { return this._awayFrom; }
            set { this._awayFrom = value; }
        }

        // Check to see if AwayFrom property is set
        internal bool IsSetAwayFrom()
        {
            return this._awayFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The initial comment that you enter about the practice run. Be aware that this comment
        /// can be overwritten by Amazon Web Services if the automatic check for balanced capacity
        /// fails. For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.capacity-check.html">
        /// Capacity checks for practice runs</a> in the Amazon Application Recovery Controller
        /// Developer Guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that you want to start a practice run zonal shift
        /// for. The identifier is the Amazon Resource Name (ARN) for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}