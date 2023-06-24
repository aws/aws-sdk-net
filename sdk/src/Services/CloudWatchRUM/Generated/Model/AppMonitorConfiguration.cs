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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// This structure contains much of the configuration data for the app monitor.
    /// </summary>
    public partial class AppMonitorConfiguration
    {
        private bool? _allowCookies;
        private bool? _enableXRay;
        private List<string> _excludedPages = new List<string>();
        private List<string> _favoritePages = new List<string>();
        private string _guestRoleArn;
        private string _identityPoolId;
        private List<string> _includedPages = new List<string>();
        private double? _sessionSampleRate;
        private List<string> _telemetries = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowCookies. 
        /// <para>
        /// If you set this to <code>true</code>, the RUM web client sets two cookies, a session
        /// cookie and a user cookie. The cookies allow the RUM web client to collect data relating
        /// to the number of users an application has and the behavior of the application across
        /// a sequence of events. Cookies are stored in the top-level domain of the current page.
        /// </para>
        /// </summary>
        public bool AllowCookies
        {
            get { return this._allowCookies.GetValueOrDefault(); }
            set { this._allowCookies = value; }
        }

        // Check to see if AllowCookies property is set
        internal bool IsSetAllowCookies()
        {
            return this._allowCookies.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableXRay. 
        /// <para>
        /// If you set this to <code>true</code>, RUM enables X-Ray tracing for the user sessions
        /// that RUM samples. RUM adds an X-Ray trace header to allowed HTTP requests. It also
        /// records an X-Ray segment for allowed HTTP requests. You can see traces and segments
        /// from these user sessions in the X-Ray console and the CloudWatch ServiceLens console.
        /// For more information, see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray.html">What
        /// is X-Ray?</a> 
        /// </para>
        /// </summary>
        public bool EnableXRay
        {
            get { return this._enableXRay.GetValueOrDefault(); }
            set { this._enableXRay = value; }
        }

        // Check to see if EnableXRay property is set
        internal bool IsSetEnableXRay()
        {
            return this._enableXRay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludedPages. 
        /// <para>
        /// A list of URLs in your website or application to exclude from RUM data collection.
        /// </para>
        ///  
        /// <para>
        /// You can't include both <code>ExcludedPages</code> and <code>IncludedPages</code> in
        /// the same operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> ExcludedPages
        {
            get { return this._excludedPages; }
            set { this._excludedPages = value; }
        }

        // Check to see if ExcludedPages property is set
        internal bool IsSetExcludedPages()
        {
            return this._excludedPages != null && this._excludedPages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FavoritePages. 
        /// <para>
        /// A list of pages in your application that are to be displayed with a "favorite" icon
        /// in the CloudWatch RUM console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> FavoritePages
        {
            get { return this._favoritePages; }
            set { this._favoritePages = value; }
        }

        // Check to see if FavoritePages property is set
        internal bool IsSetFavoritePages()
        {
            return this._favoritePages != null && this._favoritePages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GuestRoleArn. 
        /// <para>
        /// The ARN of the guest IAM role that is attached to the Amazon Cognito identity pool
        /// that is used to authorize the sending of data to RUM.
        /// </para>
        /// </summary>
        public string GuestRoleArn
        {
            get { return this._guestRoleArn; }
            set { this._guestRoleArn = value; }
        }

        // Check to see if GuestRoleArn property is set
        internal bool IsSetGuestRoleArn()
        {
            return this._guestRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The ID of the Amazon Cognito identity pool that is used to authorize the sending of
        /// data to RUM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedPages. 
        /// <para>
        /// If this app monitor is to collect data from only certain pages in your application,
        /// this structure lists those pages. 
        /// </para>
        ///  
        /// <para>
        /// You can't include both <code>ExcludedPages</code> and <code>IncludedPages</code> in
        /// the same operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> IncludedPages
        {
            get { return this._includedPages; }
            set { this._includedPages = value; }
        }

        // Check to see if IncludedPages property is set
        internal bool IsSetIncludedPages()
        {
            return this._includedPages != null && this._includedPages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionSampleRate. 
        /// <para>
        /// Specifies the portion of user sessions to use for RUM data collection. Choosing a
        /// higher portion gives you more data but also incurs more costs.
        /// </para>
        ///  
        /// <para>
        /// The range for this value is 0 to 1 inclusive. Setting this to 1 means that 100% of
        /// user sessions are sampled, and setting it to 0.1 means that 10% of user sessions are
        /// sampled.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default of 0.1 is used, and 10% of sessions will be
        /// sampled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double SessionSampleRate
        {
            get { return this._sessionSampleRate.GetValueOrDefault(); }
            set { this._sessionSampleRate = value; }
        }

        // Check to see if SessionSampleRate property is set
        internal bool IsSetSessionSampleRate()
        {
            return this._sessionSampleRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Telemetries. 
        /// <para>
        /// An array that lists the types of telemetry data that this app monitor is to collect.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>errors</code> indicates that RUM collects data about unhandled JavaScript errors
        /// raised by your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>performance</code> indicates that RUM collects performance data about how your
        /// application and its resources are loaded and rendered. This includes Core Web Vitals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>http</code> indicates that RUM collects data about HTTP errors thrown by your
        /// application.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Telemetries
        {
            get { return this._telemetries; }
            set { this._telemetries = value; }
        }

        // Check to see if Telemetries property is set
        internal bool IsSetTelemetries()
        {
            return this._telemetries != null && this._telemetries.Count > 0; 
        }

    }
}