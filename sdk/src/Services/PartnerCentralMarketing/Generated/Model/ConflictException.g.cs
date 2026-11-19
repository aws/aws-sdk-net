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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// The request conflicts with the current state of the resource.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public partial class ConflictException : AmazonPartnerCentralMarketingException
    {
        /// <summary>
        /// Default constructor for ConflictException
        /// message.
        /// </summary>
        public ConflictException() : base() { }

        /// <summary>
        /// Constructs a new ConflictException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ConflictException(string message) : base(message) { }

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        public ConflictException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        public ConflictException(Exception innerException) : base(innerException) { }

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        public ConflictException(string message, Exception innerException, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, innerException, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Construct instance of ConflictException
        /// </summary>
        public ConflictException(string message, Amazon.Runtime.ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) : base(message, errorType, errorCode, requestId, statusCode) { }

        /// <summary>
        /// Gets and sets the property Reason. Machine-readable cause, for clients that branch
        /// on it. An open set of `SCREAMING_SNAKE_CASE` tokens, deliberately typed as a string
        /// rather than an enum. `ConflictException` is shared by every resource in this service,
        /// so an enum here would accumulate values that are meaningful for one resource and inapplicable
        /// to the rest — the cohesiveness problem the Backward Compatibility standard describes
        /// under "Sharing enums" — and each new value would force an SDK regeneration on callers
        /// who can never encounter it. Clients MUST treat an unrecognised value as an unspecified
        /// conflict and fall back to `Message`. Values in use today: From the campaign asset
        /// activation path. Every one of these is decided before the operation returns, so a
        /// caller that receives one knows nothing was started. These two are thrown by `DeactivateCampaignAsset`,
        /// which refuses one asset outright. `StartCampaignAssetActivationTask` reports the same
        /// two causes **per asset** as a FAILED task entry instead of throwing, because one bad
        /// identifier must not refuse the twenty-four good ones beside it — so the spellings
        /// are deliberately identical to `CampaignAssetStateReason`'s, letting a client match
        /// one string whichever way the refusal arrived. The two types evolve independently on
        /// purpose: this is an open string shared by every resource, that is a closed enum owned
        /// by one operation. - `ASSET_START_IN_PROGRESS` — the asset is already being started,
        /// or another caller changed it during this request. Retryable once the outcome is visible.
        /// - `PREREQUISITE_ASSET_NOT_ACTIVE` — this asset embeds output from another asset that
        /// is not live. `ResourceId` carries that asset's identifier. From the prerequisite edges
        /// between a campaign's assets — an email that embeds its landing page's URL. Both refuse
        /// the whole request and write nothing. - `PREREQUISITE_ASSET_MISSING` — from `BatchCreateCampaignAsset`:
        /// an entry's blueprint embeds another blueprint's output, and that blueprint is neither
        /// named in the same request nor already an asset on the campaign. Retry with it in the
        /// request. `ResourceId` carries the missing blueprint's identifier. - `ASSET_HAS_DEPENDENTS`
        /// — from `DeleteCampaignAsset`: another asset on the campaign embeds this asset's output,
        /// so deleting it would leave that asset unactivatable. Delete the dependents first.
        /// The message names them. `CAMPAIGN_COMPLETED` — the campaign is complete (the UTC date
        /// is after its `EndOn`), so it and its assets are read-only. Refuses `UpdateCampaign`,
        /// `BatchCreateCampaignAsset`, `UpdateCampaignAsset`, `DeleteCampaignAsset` and `StartCampaignAssetActivationTask`;
        /// never `DeactivateCampaignAsset`. **Not retryable, and not fixable** — `EndOn` cannot
        /// be moved once it has passed, so nothing the caller does will make the write succeed.
        /// `ResourceId` carries the campaign identifier. ⚠️ This is the one conflict reason whose
        /// condition **never clears**, which sits awkwardly with `ConflictException` promising
        /// a state that may change. It is a conflict rather than a validation failure because
        /// the request is well formed and would have succeeded a moment earlier — the resource's
        /// state is what refuses it, which is what this exception is for. Contrast `ASSET_NOT_STARTABLE`,
        /// which moved to `ValidationException` precisely because it is a property of the asset's
        /// *type* rather than of its state. ⚠️ **`COMPLETED` also exists as a `CampaignAssetExportTaskStatus`
        /// value, on a different axis.** That one means an export archive finished assembling.
        /// The two are unrelated and must not be unified. `CAMPAIGN_HAS_ACTIVE_ASSETS` — from
        /// `DeleteCampaign`: at least one of the campaign's assets is live, and deleting the
        /// campaign would orphan what the delivery platform still serves or sends. Deactivate
        /// those assets with `DeactivateCampaignAsset`, then retry. The message names them. `ResourceId`
        /// carries the campaign identifier. `CAMPAIGN_ACTIVATION_IN_PROGRESS` — from `StartCampaignAssetActivationTask`
        /// and `DeleteCampaign`, refusing the whole request: one activation task runs on a campaign
        /// at a time. `ResourceId` carries the **holding task's id**, so a caller can poll `GetCampaignAssetActivationTask`
        /// rather than guess. Retryable once that task reaches a terminal status. `SERVICE_LINKED_ROLE_DELETION_IN_PROGRESS`
        /// — from `StartCampaignAssetActivationTask`, refusing the whole request: this service's
        /// service-linked role is being deleted, so no asset may go live. Not a lease conflict:
        /// `ResourceId` is unset and there is no task to poll. Retryable after a short wait;
        /// if the role was deleted, the next activation recreates it. `LAYOUT_LOCKED_AFTER_ACTIVATION`
        /// — from `UpdateCampaignAsset`, refusing a `Layout` change on a multi-layout asset that
        /// has activated successfully at least once (DG-044). The published object is that layout's,
        /// so switching would leave the asset describing a layout that is not the one live. **Not
        /// fixable**: the asset keeps its layout for life. A failed activation does not lock
        /// it. Re-sending the layout already selected is not a change and is accepted. `ResourceId`
        /// carries the asset identifier. `ASSET_START_IN_PROGRESS` — also from `UpdateCampaignAsset`,
        /// refusing any edit to an asset the campaign's running activation task has accepted
        /// and not yet finished: the run publishes the content it read, so an edit accepted mid-run
        /// would either be published unvalidated or never published. Nothing is written. Retryable
        /// once the asset's outcome on the task (`GetCampaignAssetActivationTask`) is terminal;
        /// the asset's siblings may still be running. `ResourceId` carries the asset identifier.
        /// `ASSET_ALREADY_ACTIVE` — from `UpdateCampaignAsset`, refusing any change to a live
        /// email or social post, content or schedule. Deactivate it first; the next activation
        /// sends everything current. Landing pages and documents are edited live and converge
        /// by re-activation. `ResourceId` carries the asset identifier. `ASSET_NOT_DEACTIVATABLE`
        /// — from `DeactivateCampaignAsset`, for an asset that can't be stopped: a document,
        /// banner or landing page until the campaign has completed, when it becomes removable.
        /// Until then, update it and activate it again. `ResourceId` carries the asset identifier.
        /// `ASSET_HAS_LOCKED_SENDS` — from `DeactivateCampaignAsset`, within an hour of the asset's
        /// send (a social post's publish), when it can no longer be withdrawn. `ASSET_ALREADY_DELIVERED`
        /// — the same, once that time has passed: a sent email or a published post cannot be
        /// recalled. Neither is retryable. Three values were removed with the campaign lifecycle
        /// and the singular activate, and none should be re-added here: - `CAMPAIGN_NOT_STARTED`
        /// — a campaign has no state to be started out of. - `ASSET_NOT_STARTABLE` — moved to
        /// `ValidationException`, with no reason. The value's own documentation said it was "not
        /// retryable and not fixable: it is a property of the asset's type", and `ConflictException`
        /// promises a state that may change. The gate itself stays — deleting it lets a download-only
        /// asset into a task with no dispatch arm, which would succeed and do nothing. - `ASSET_START_UNCONFIRMED`
        /// — described a state that no longer occurs. DG cannot be more idempotent than a platform
        /// whose social create has no idempotency key, so an ambiguous hand-over is now an ordinary
        /// failure carrying `INTERNAL_ERROR`. Holding the asset in a distinct state bought a
        /// guarantee that was never real, and had no exit.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property ResourceId. The affected resource identifier. For a uniqueness
        /// conflict this is the identifier of the *existing* resource, so the caller can act
        /// on it without a separate lookup.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. The affected resource type.
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ConflictException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ConflictException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.Reason = (string)info.GetValue("Reason", typeof(string));
            this.ResourceId = (string)info.GetValue("ResourceId", typeof(string));
            this.ResourceType = (string)info.GetValue("ResourceType", typeof(string));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
        [System.Security.SecurityCritical]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Reason", this.Reason);
            info.AddValue("ResourceId", this.ResourceId);
            info.AddValue("ResourceType", this.ResourceType);
        }
#endif
    }
}
