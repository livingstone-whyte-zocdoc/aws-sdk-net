/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CodeGuruReviewer.Model;
using Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations;
using Amazon.CodeGuruReviewer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CodeGuruReviewer
{
    /// <summary>
    /// Implementation for accessing CodeGuruReviewer
    ///
    /// This section provides documentation for the Amazon CodeGuru Reviewer API operations.
    /// </summary>
    public partial class AmazonCodeGuruReviewerClient : AmazonServiceClient, IAmazonCodeGuruReviewer
    {
        private static IServiceMetadata serviceMetadata = new AmazonCodeGuruReviewerMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCodeGuruReviewerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruReviewerConfig()) { }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCodeGuruReviewerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(AmazonCodeGuruReviewerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCodeGuruReviewerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Credentials and an
        /// AmazonCodeGuruReviewerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(AWSCredentials credentials, AmazonCodeGuruReviewerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCodeGuruReviewerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruReviewerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCodeGuruReviewerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruReviewerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCodeGuruReviewerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCodeGuruReviewerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCodeGuruReviewerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCodeGuruReviewerClient Configuration Object</param>
        public AmazonCodeGuruReviewerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCodeGuruReviewerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateRepository

        internal virtual AssociateRepositoryResponse AssociateRepository(AssociateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRepositoryResponseUnmarshaller.Instance;

            return Invoke<AssociateRepositoryResponse>(request, options);
        }



        /// <summary>
        /// Associates an AWS CodeCommit repository with Amazon CodeGuru Reviewer. When you associate
        /// an AWS CodeCommit repository with Amazon CodeGuru Reviewer, Amazon CodeGuru Reviewer
        /// will provide recommendations for each pull request raised within the repository. You
        /// can view recommendations in the AWS CodeCommit repository.
        /// 
        ///  
        /// <para>
        /// You can associate a GitHub repository using the Amazon CodeGuru Reviewer console.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/AssociateRepository">REST API Reference for AssociateRepository Operation</seealso>
        public virtual Task<AssociateRepositoryResponse> AssociateRepositoryAsync(AssociateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCodeReview

        internal virtual DescribeCodeReviewResponse DescribeCodeReview(DescribeCodeReviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeReviewResponseUnmarshaller.Instance;

            return Invoke<DescribeCodeReviewResponse>(request, options);
        }



        /// <summary>
        /// Returns the metadaata associated with the code review along with its status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCodeReview service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeCodeReview">REST API Reference for DescribeCodeReview Operation</seealso>
        public virtual Task<DescribeCodeReviewResponse> DescribeCodeReviewAsync(DescribeCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCodeReviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCodeReviewResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCodeReviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRecommendationFeedback

        internal virtual DescribeRecommendationFeedbackResponse DescribeRecommendationFeedback(DescribeRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Describes the customer feedback for a CodeGuru Reviewer recommendation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRecommendationFeedback">REST API Reference for DescribeRecommendationFeedback Operation</seealso>
        public virtual Task<DescribeRecommendationFeedbackResponse> DescribeRecommendationFeedbackAsync(DescribeRecommendationFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecommendationFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRepositoryAssociation

        internal virtual DescribeRepositoryAssociationResponse DescribeRepositoryAssociation(DescribeRepositoryAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeRepositoryAssociationResponse>(request, options);
        }



        /// <summary>
        /// Describes a repository association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRepositoryAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRepositoryAssociation service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DescribeRepositoryAssociation">REST API Reference for DescribeRepositoryAssociation Operation</seealso>
        public virtual Task<DescribeRepositoryAssociationResponse> DescribeRepositoryAssociationAsync(DescribeRepositoryAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRepositoryAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRepositoryAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRepositoryAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRepository

        internal virtual DisassociateRepositoryResponse DisassociateRepository(DisassociateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRepositoryResponseUnmarshaller.Instance;

            return Invoke<DisassociateRepositoryResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between Amazon CodeGuru Reviewer and a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateRepository service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ConflictException">
        /// The requested operation would cause a conflict with the current state of a service
        /// resource associated with the request. Resolve the conflict before retrying this request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.NotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/DisassociateRepository">REST API Reference for DisassociateRepository Operation</seealso>
        public virtual Task<DisassociateRepositoryResponse> DisassociateRepositoryAsync(DisassociateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCodeReviews

        internal virtual ListCodeReviewsResponse ListCodeReviews(ListCodeReviewsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return Invoke<ListCodeReviewsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the code reviews that the customer has created in the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviews service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        public virtual Task<ListCodeReviewsResponse> ListCodeReviewsAsync(ListCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCodeReviewsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCodeReviewsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCodeReviewsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendationFeedback

        internal virtual ListRecommendationFeedbackResponse ListRecommendationFeedback(ListRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Lists the customer feedback for a CodeGuru Reviewer recommendation for all users.
        /// This API will be used from the console to extract the previously given feedback by
        /// the user to pre-populate the feedback emojis for all recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendationFeedback">REST API Reference for ListRecommendationFeedback Operation</seealso>
        public virtual Task<ListRecommendationFeedbackResponse> ListRecommendationFeedbackAsync(ListRecommendationFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendations

        internal virtual ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns the list of all recommendations for a completed code review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        public virtual Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositoryAssociations

        internal virtual ListRepositoryAssociationsResponse ListRepositoryAssociations(ListRepositoryAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListRepositoryAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists repository associations. You can optionally filter on one or more of the following
        /// recommendation properties: provider types, states, names, and owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoryAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRepositoryAssociations service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/ListRepositoryAssociations">REST API Reference for ListRepositoryAssociations Operation</seealso>
        public virtual Task<ListRepositoryAssociationsResponse> ListRepositoryAssociationsAsync(ListRepositoryAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoryAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoryAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRepositoryAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRecommendationFeedback

        internal virtual PutRecommendationFeedbackResponse PutRecommendationFeedback(PutRecommendationFeedbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutRecommendationFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Stores customer feedback for a CodeGuru-Reviewer recommendation. When this API is
        /// called again with different reactions the previous feedback is overwritten.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecommendationFeedback service method, as returned by CodeGuruReviewer.</returns>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.InternalServerException">
        /// The server encountered an internal error and is unable to complete the request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ResourceNotFoundException">
        /// The resource specified in the request was not found.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruReviewer.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguru-reviewer-2019-09-19/PutRecommendationFeedback">REST API Reference for PutRecommendationFeedback Operation</seealso>
        public virtual Task<PutRecommendationFeedbackResponse> PutRecommendationFeedbackAsync(PutRecommendationFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutRecommendationFeedbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}