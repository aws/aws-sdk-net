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
    /// This is the response object from the CreatePracticeRunConfiguration operation.
    /// </summary>
    public partial class CreatePracticeRunConfigurationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _name;
        private PracticeRunConfiguration _practiceRunConfiguration;
        private ZonalAutoshiftStatus _zonalAutoshiftStatus;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you configured the practice run
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource that you configured the practice run for. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property PracticeRunConfiguration. 
        /// <para>
        /// A practice run configuration for a resource. Configurations include the outcome alarm
        /// that you specify for practice runs, and, optionally, a blocking alarm and blocking
        /// dates and windows.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PracticeRunConfiguration PracticeRunConfiguration
        {
            get { return this._practiceRunConfiguration; }
            set { this._practiceRunConfiguration = value; }
        }

        // Check to see if PracticeRunConfiguration property is set
        internal bool IsSetPracticeRunConfiguration()
        {
            return this._practiceRunConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The status for zonal autoshift for a resource. When you specify <c>ENABLED</c> for
        /// the autoshift status, Amazon Web Services shifts traffic away from shifts away application
        /// resource traffic from an Availability Zone, on your behalf, when internal telemetry
        /// indicates that there is an Availability Zone impairment that could potentially impact
        /// customers.
        /// </para>
        ///  
        /// <para>
        /// When you enable zonal autoshift, you must also configure practice runs for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ZonalAutoshiftStatus ZonalAutoshiftStatus
        {
            get { return this._zonalAutoshiftStatus; }
            set { this._zonalAutoshiftStatus = value; }
        }

        // Check to see if ZonalAutoshiftStatus property is set
        internal bool IsSetZonalAutoshiftStatus()
        {
            return this._zonalAutoshiftStatus != null;
        }

    }
}