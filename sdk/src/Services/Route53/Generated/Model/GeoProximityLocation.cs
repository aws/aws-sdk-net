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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// (Resource record sets only): A complex type that lets you specify where your resources
    /// are located. Only one of <c>LocalZoneGroup</c>, <c>Coordinates</c>, or <c>Amazon Web
    /// ServicesRegion</c> is allowed per request at a time.
    /// 
    ///  
    /// <para>
    /// For more information about geoproximity routing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geoproximity.html">Geoproximity
    /// routing</a> in the <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GeoProximityLocation
    {
        private string _awsRegion;
        private string _localZoneGroup;
        private Coordinates _coordinates;
        private int? _bias;

        /// <summary>
        /// Gets and sets the property AWSRegion. 
        /// <para>
        ///  The Amazon Web Services Region the resource you are directing DNS traffic to, is
        /// in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AWSRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AWSRegion property is set
        internal bool IsSetAWSRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LocalZoneGroup. 
        /// <para>
        ///  Specifies an Amazon Web Services Local Zone Group. 
        /// </para>
        ///  
        /// <para>
        /// A local Zone Group is usually the Local Zone code without the ending character. For
        /// example, if the Local Zone is <c>us-east-1-bue-1a</c> the Local Zone Group is <c>us-east-1-bue-1</c>.
        /// </para>
        ///  
        /// <para>
        /// You can identify the Local Zones Group for a specific Local Zone by using the <a href="https://docs.aws.amazon.com/cli/latest/reference/ec2/describe-availability-zones.html">describe-availability-zones</a>
        /// CLI command:
        /// </para>
        ///  
        /// <para>
        /// This command returns: <c>"GroupName": "us-west-2-den-1"</c>, specifying that the Local
        /// Zone <c>us-west-2-den-1a</c> belongs to the Local Zone Group <c>us-west-2-den-1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LocalZoneGroup
        {
            get { return this._localZoneGroup; }
            set { this._localZoneGroup = value; }
        }

        // Check to see if LocalZoneGroup property is set
        internal bool IsSetLocalZoneGroup()
        {
            return this._localZoneGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Coordinates. 
        /// <para>
        ///  Contains the longitude and latitude for a geographic region. 
        /// </para>
        /// </summary>
        public Coordinates Coordinates
        {
            get { return this._coordinates; }
            set { this._coordinates = value; }
        }

        // Check to see if Coordinates property is set
        internal bool IsSetCoordinates()
        {
            return this._coordinates != null;
        }

        /// <summary>
        /// Gets and sets the property Bias. 
        /// <para>
        ///  The bias increases or decreases the size of the geographic region from which Route 53
        /// routes traffic to a resource. 
        /// </para>
        ///  
        /// <para>
        /// To use <c>Bias</c> to change the size of the geographic region, specify the applicable
        /// value for the bias:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expand the size of the geographic region from which Route 53 routes traffic to
        /// a resource, specify a positive integer from 1 to 99 for the bias. Route 53 shrinks
        /// the size of adjacent regions. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To shrink the size of the geographic region from which Route 53 routes traffic to
        /// a resource, specify a negative bias of -1 to -99. Route 53 expands the size of adjacent
        /// regions. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=-99, Max=99)]
        public int? Bias
        {
            get { return this._bias; }
            set { this._bias = value; }
        }

        // Check to see if Bias property is set
        internal bool IsSetBias()
        {
            return this._bias.HasValue; 
        }

    }
}