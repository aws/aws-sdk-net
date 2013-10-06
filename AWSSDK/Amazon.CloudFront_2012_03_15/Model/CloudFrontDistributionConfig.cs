/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-01
 *
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Util;

namespace Amazon.CloudFront_2012_03_15.Model
{
    /// <summary>
    /// The CloudFrontDistributionConfig complex type describes a distribution's configuration information.
    /// It is used as a request element in Create a Distribution and Set a Distribution's Configuration.
    /// It is used as a response element in Get a Distribution's Information and Get a Distribution's
    /// Configuration.
    /// <para>A distribution configuration objects consists of the following items:
    /// <list type="number">
    /// <item>Caller Reference</item>
    /// <item>Origin S3 Bucket</item>
    /// <item>Comment</item>
    /// <item>A list of CNAMEs for the distribution</item>
    /// <item>Enabled flag</item>
    /// <item>Bucket Logging details</item>
    /// <item>CloudFront Origin Access Identity associated with the distribution.
    /// This is a virtual identity you use to let CloudFront fetch private content 
    /// from your bucket.</item>
    /// <item>The AWS Accounts that have URL signing privileges for Private Content.</item>
    /// </list>
    /// </para>
    /// For more information, please visit:
    /// <see href="http://docs.amazonwebservices.com/AmazonCloudFront/latest/APIReference/DistributionConfigDatatype.html"/>
    /// </summary>
    [Serializable()]
    public class CloudFrontDistributionConfig : CloudFrontDistributionConfigBase
    {
        #region Private Members

        CustomOrigin _customOrigin;
        List<Protocol> requiredProtocols;
        string defaultRootObject;

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates an XML representation of the CloudFront
        /// distribution configuration. The resulting XML
        /// can be sent to CloudFront when creating or updating
        /// a distribution.
        /// </summary>
        /// <returns>
        /// XML representation of the distribution's configuration
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(1024);
            sb.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?><DistributionConfig ");
            sb.Append("xmlns=\"http://cloudfront.amazonaws.com/doc/2010-11-01/\">");
            sb.Append(base.ToString());

            // Represent RequiredProtocols in the xml
            if (IsSetRequiredProtocols())
            {
                sb.Append("<RequiredProtocols>");
                foreach (Protocol reqProt in RequiredProtocols)
                {
                    sb.Append(String.Concat("<Protocol>", reqProt, "</Protocol>"));
                }
                sb.Append("</RequiredProtocols>");
            }
            if (IsDefaultRootObjectSet())
            {
                sb.Append(String.Concat("<DefaultRootObject>", this.DefaultRootObject, "</DefaultRootObject>"));
            }
            if(this.IsSetCustomOrigin())
            {
                sb.Append(this.CustomOrigin.ToString());
            }

            sb.Append("</DistributionConfig>");
            return sb.ToString();
        }

        #endregion

        #region Fluid API

        /// <summary>
        /// Sets the Origin property.
        /// </summary>
        /// <param name="origin">Origin property</param>
        /// <returns>this instance</returns>        
        [Obsolete("This property has been obsoleted in favor of the WithS3Origin method.")]
        public CloudFrontDistributionConfig WithOrigin(string origin)
        {
#pragma warning disable 0618
            Origin = origin;
#pragma warning restore 0618
            return this;
        }

        /// <summary>
        /// Sets the Comment property.
        /// </summary>
        /// <param name="comment">Comment property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithComment(string comment)
        {
            this.Comment = comment;
            return this;
        }

        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">CallerReference property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithCallerReference(string callerReference)
        {
            this.CallerReference = callerReference;
            return this;
        }

        /// <summary>
        /// Sets the CNAME property. If you set more than 10 CNAME aliases for a distribution,
        /// a <code>TooManyDistributionCNAMEs</code> exception will be returned by CloudFront.
        /// </summary>
        /// <param name="cnames">CNAME property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithCNames(params string[] cnames)
        {
            foreach (string cname in cnames)
            {
                CNAME.Add(cname);
            }
            return this;
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">Enabled property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithEnabled(bool enabled)
        {
            this.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Sets the OriginAccessIdentity property.
        /// </summary>
        /// <param name="identity">OriginAccessIdentity property</param>
        /// <returns>this instance</returns>
        [Obsolete("This property has been obsoleted in favor of the WithS3Origin method.")]
        public CloudFrontDistributionConfig WithOriginAccessIdentity(CloudFrontOriginAccessIdentity identity)
        {
#pragma warning disable 0618
            OriginAccessIdentity = identity;
#pragma warning restore 0618
            return this;
        }

        /// <summary>
        /// Sets the TrustedSigners property.
        /// This specifies any AWS accounts you want to permit to create signed URLs for private content.
        /// </summary>
        /// <param name="signers">TrustedSigners property is set to this value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithTrustedSigners(UrlTrustedSigners signers)
        {
            this.TrustedSigners = signers;
            return this;
        }

        /// <summary>
        /// Gets and sets the CustomOrigin property.
        /// The CustomOrigin contains the information for a non Amazon S3 Bucket origin.
        /// </summary>
        public CustomOrigin CustomOrigin
        {
            get { return this._customOrigin; }
            set { this._customOrigin = value; }
        }

        /// <summary>
        /// Sets the CustomOrigin property.
        /// The CustomOrigin contains the information for a non Amazon S3 Bucket origin.
        /// This instance is returned to allow method chaining.
        /// </summary>
        /// <param name="customOrigin">CustomOrigin property is set to this value.</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithCustomOrigin(CustomOrigin customOrigin)
        {
            this.CustomOrigin = customOrigin;
            return this;
        }

        internal bool IsSetCustomOrigin()
        {
            return this._customOrigin != null;
        }

        #endregion

        #region Logging

        /// <summary>
        /// Sets the Logging property.
        /// </summary>
        /// <param name="bucket">The bucket into which logs will be put</param>
        /// <param name="prefix">The prefix for the log files</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithLogging(string bucket, string prefix)
        {
            if (String.IsNullOrEmpty(bucket))
            {
                throw new ArgumentNullException(
                    "bucket",
                    "The bucket specified as part of the Logging Config is null or the empty string"
                    );
            }

            Logging = new Tuple<string, string>(bucket, prefix);
            return this;
        }

        #endregion

        #region RequiredProtocols

        /// <summary>
        /// Gets and sets the RequiredProtocols property.
        /// Defines the protocols required for your distribution. Use this element to restrict 
        /// access to your distribution solely to HTTPS requests. Without this element, 
        /// CloudFront can use any available protocol to serve the request.
        /// For a list of possible protocol values, refer
        /// <see cref="T:Amazon.CloudFront.Model.Protocol"/>.
        /// </summary>
        [XmlElementAttribute(ElementName = "Protocol")]
        public List<Protocol> RequiredProtocols
        {
            get
            {
                if (this.requiredProtocols == null)
                {
                    this.requiredProtocols = new List<Protocol>();
                }
                return this.requiredProtocols;
            }
            set { this.requiredProtocols = value; }
        }

        /// <summary>
        /// Checks if RequiredProtocols property is set.
        /// </summary>
        /// <returns>true if RequiredProtocols property is set.</returns>
        internal bool IsSetRequiredProtocols()
        {
            return (RequiredProtocols.Count > 0);
        }

        /// <summary>
        /// Sets the RequiredProtocols property.
        /// Defines the protocols required for your distribution. Use this element to restrict 
        /// access to your distribution solely to HTTPS requests. Without this element, 
        /// CloudFront can use any available protocol to serve the request.
        /// For a list of possible protocol values, refer
        /// <see cref="T:Amazon.CloudFront.Model.Protocol"/>.
        /// </summary>
        /// <param name="protocols">RequiredProtocols property is set to this value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithRequiredProtocols(params Protocol[] protocols)
        {
            foreach (Protocol prot in protocols)
            {
                RequiredProtocols.Add(prot);
            }
            return this;
        }

        #endregion

        #region DefaultRootObject

        /// <summary>
        /// Gets and sets the DefaultRootObject property.
        /// Defines the object that will be returned for requests made to the root URL of 
        /// the distribution.
        /// </summary>
        public string DefaultRootObject
        {
            get
            {
                return this.defaultRootObject;
            }
            set
            {
                this.defaultRootObject = value;
            }
        }

        /// <summary>
        /// Sets the DefaultRootObject property.
        /// </summary>
        /// <param name="rootObject">The name of the default root object.</param>
        /// <returns>This instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CloudFrontDistributionConfig WithDefaultRootObject(string rootObject)
        {
            this.defaultRootObject = rootObject;
            return this;
        }

        /// <summary>
        /// Checks to see if the DefaultRootObject property is set.
        /// </summary>
        /// <returns>True if DefaultRootObject is set. False otherwise.</returns>
        internal bool IsDefaultRootObjectSet()
        {
            return this.defaultRootObject != null;
        }

        #endregion
    }
}
