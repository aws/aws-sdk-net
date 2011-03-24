/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon CloudFront.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class CloudFrontActionIdentifers
    {
        /// <summary>
        /// Represents any action being taken on AWS CloudFormation.
        /// </summary>
        public static readonly ActionIdentifier AllCloudFrontActions = new ActionIdentifier("cloudfront:*");

        /// <summary>
        /// Action for the <code>CreateDistribution</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.CreateDistribution"/>
        public static readonly ActionIdentifier CreateDistribution = new ActionIdentifier("cloudfront:CreateDistribution");

        /// <summary>
        /// Action for the <code>GetDistributionInfo</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetDistributionInfo"/>
        public static readonly ActionIdentifier GetDistribution = new ActionIdentifier("cloudfront:GetDistribution");

        /// <summary>
        /// Action for the <code>GetDistributionConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetDistributionConfig"/>
        public static readonly ActionIdentifier GetDistributionConfig = new ActionIdentifier("cloudfront:GetDistributionConfig");

        /// <summary>
        /// Action for the <code>SetDistributionConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.SetDistributionConfig"/>
        public static readonly ActionIdentifier UpdateDistribution = new ActionIdentifier("cloudfront:UpdateDistribution");

        /// <summary>
        /// Action for the <code>ListDistributions</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.ListDistributions"/>
        public static readonly ActionIdentifier ListDistributions = new ActionIdentifier("cloudfront:ListDistributions");

        /// <summary>
        /// Action for the <code>DeleteDistribution</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.DeleteDistribution"/>
        public static readonly ActionIdentifier DeleteDistribution = new ActionIdentifier("cloudfront:DeleteDistribution");

        /// <summary>
        /// Action for the <code>CreateStreamingDistribution</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.CreateStreamingDistribution"/>
        public static readonly ActionIdentifier CreateStreamingDistribution = new ActionIdentifier("cloudfront:CreateStreamingDistribution");

        /// <summary>
        /// Action for the <code>GetStreamingDistributionInfo</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionInfo"/>
        public static readonly ActionIdentifier GetStreamingDistribution = new ActionIdentifier("cloudfront:GetStreamingDistribution");

        /// <summary>
        /// Action for the <code>GetStreamingDistributionConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetStreamingDistributionConfig"/>
        public static readonly ActionIdentifier GetStreamingDistributionConfig = new ActionIdentifier("cloudfront:GetStreamingDistributionConfig");

        /// <summary>
        /// Action for the <code>SetStreamingDistributionConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.SetStreamingDistributionConfig"/>
        public static readonly ActionIdentifier UpdateStreamingDistribution = new ActionIdentifier("cloudfront:UpdateStreamingDistribution");

        /// <summary>
        /// Action for the <code>ListStreamingDistributions</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.ListStreamingDistributions"/>
        public static readonly ActionIdentifier ListStreamingDistributions = new ActionIdentifier("cloudfront:ListStreamingDistributions");

        /// <summary>
        /// Action for the <code>DeleteStreamingDistribution</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.DeleteStreamingDistribution"/>
        public static readonly ActionIdentifier DeleteStreamingDistribution = new ActionIdentifier("cloudfront:DeleteStreamingDistribution");

        /// <summary>
        /// Action for the <code>PostInvalidation</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.PostInvalidation"/>
        public static readonly ActionIdentifier CreateInvalidation = new ActionIdentifier("cloudfront:CreateInvalidation");

        /// <summary>
        /// Action for the <code>GetInvalidation</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
        public static readonly ActionIdentifier GetInvalidation = new ActionIdentifier("cloudfront:GetInvalidation");

        /// <summary>
        /// Action for the <code>GetInvalidationList</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetInvalidationList"/>
        public static readonly ActionIdentifier ListInvalidations = new ActionIdentifier("cloudfront:ListInvalidations");

        /// <summary>
        /// Action for the <code>CreateOriginAccessIdentity</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.CreateOriginAccessIdentity"/>
        public static readonly ActionIdentifier CreateCloudFrontOriginAccessIdentity = new ActionIdentifier("cloudfront:CreateCloudFrontOriginAccessIdentity");

        /// <summary>
        /// Action for the <code>GetOriginAccessIdentityInfo</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetOriginAccessIdentityInfo"/>
        public static readonly ActionIdentifier GetCloudFrontOriginAccessIdentity = new ActionIdentifier("cloudfront:GetCloudFrontOriginAccessIdentity");

        /// <summary>
        /// Action for the <code>GetOriginAccessIdentityConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.GetOriginAccessIdentityConfig"/>
        public static readonly ActionIdentifier GetCloudFrontOriginAccessIdentityConfig = new ActionIdentifier("cloudfront:GetCloudFrontOriginAccessIdentityConfig");

        /// <summary>
        /// Action for the <code>SetOriginAccessIdentityConfig</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.SetOriginAccessIdentityConfig"/>
        public static readonly ActionIdentifier UpdateCloudFrontOriginAccessIdentity = new ActionIdentifier("cloudfront:UpdateCloudFrontOriginAccessIdentity");

        /// <summary>
        /// Action for the <code>ListOriginAccessIdentities</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.ListOriginAccessIdentities"/>
        public static readonly ActionIdentifier ListCloudFrontOriginAccessIdentities = new ActionIdentifier("cloudfront:ListCloudFrontOriginAccessIdentities");

        /// <summary>
        /// Action for the <code>DeleteOriginAccessIdentity</code> operation.
        /// </summary>
        /// <see cref="M:Amazon.CloudFront.AmazonCloudFront.DeleteOriginAccessIdentity"/>
        public static readonly ActionIdentifier DeleteCloudFrontOriginAccessIdentity = new ActionIdentifier("cloudfront:DeleteCloudFrontOriginAccessIdentity");


    }
}
