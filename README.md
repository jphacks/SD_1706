# KAOSS TAKT
↓クリックしたらYoutubeのリンクに飛びます
[![KAOSS TAKT](https://raw.github.com/GabLeRoux/WebMole/master/ressources/WebMole_Youtube_Video.png)](https://www.youtube.com/watch?v=1vL223QKuT0&feature=youtu.be)




## 製品概要
### DJ x Tech♪♪

### 背景（製品開発のきっかけ、課題等）
 
ちょうど深夜一時のナイトクラブを想像してほしい。DJがベースの効いた音楽をフロアにドロップする。爆音がフロアを満たす中、DJもオーディエンスもリズムの身を任せて飛び跳ね、フロアとDJブースの一体感が最高潮に達する。
ここで、DJがエフェクターを曲にかけようとするとしよう。彼/彼女は、フロアから視線を下げてDJミキサーのエフェクターに集中しなければならない。これではエフェクターをかけるときに必然的に会場の一体感は途切れてしまう！この問題を解決するために今回は加速度センサーを利用してDJブースの上に仮想的なエフェクターをつくる。


### 製品説明（具体的な製品の説明）

* 本デバイスはDJをしながらパフォーマンスを行うことができるデバイスである．
* パフォーマンスを行った際に，アンドロイド端末で取得した加速度やジャイロのデータを利用して，曲のフィルタ周波数の値を変化させる．
* フィルタ周波数の変化の調整は，実際にクラブやバーでDJを行っているメンバーの経験をもとに調整した．

### 特長

#### 1. 特長1

曲のハイパス/ローパスフィルタを周波数をダイナミックにスマートフォンの動きで操作できる。


#### 2. 特長2
スマートフォンの傾きの２つの軸にそれぞれハイパスフィルターとエフェクターをアサイン。２つのエフェクトを同時に操作可能。


#### 3. 特長3
加速度センサーをサンプラーにアサイン。スマートフォンを振ることでシンバルなどのサンプルを鳴らすことが可能。


### 解決出来ること
今まではエフェクターをDJミキサーからかけていたため、エフェクターをかけるためにDJミキサーに注意を向けなければいけなかった。一方、KAOSS TAKTではDJブースの上の空間全体をエフェクターのコントローラーとして使えるようになるため、会場との一体感を損なうことなくエフェクトをかけることが可能になる・また、エフェクトをダイナミックな動きでかけることができるようになるため、オーディエンスに対してよりアピーリングなパフォーマンスが可能になる。

### 今後の展望


* 複数台の端末でパフォーマンスを行ったときに曲が変化するようにし，会場全体の盛り上がりを音楽やエフェクトに反映できるようにすることで、「体験の共有」を支援するようなデバイスをつくりたい．具体的にはWebSocketで複数の端末からのデータをunityで処理して送る，といったことを考えている．
* パフォーマンスをしたときに観客が反応するといった要素をVRで実装し，「いかにパフォーマンスをして，観客を盛り上げるか」といった対戦要素を持ったゲーム機能をつけたい
* Vidoe Jockeyなどの視覚的なパフォーマンスのコントローラーとしても使えるようにしたい。
* 他には曲のチューニングの幅を増やしたり，別々の曲を組み合わせるといった機能を付加したい。


また，本来のアイディアは
「曲のポーカルやドラムを自由に抜いたり組み合わせたりして，新しい楽曲を作成するシステム」を作成しようとしていた
（1日目の17時に路線変更．NECの方に質問しまくりました．対応して下さり誠に感謝しております）
これらを連携させて，総合的なパフォーマンスアプリケーションにしたい．


## 開発内容・開発技術
### 活用した技術
#### API・データ
今回スポンサーから提供されたAPI、製品などの外部技術があれば記述をして下さい。

* 
* 
* 

#### フレームワーク・ライブラリ・モジュール
* Unity
* Android VR
* Unityアセットストア

#### デバイス
* Android

### 研究内容・事前開発プロダクト（任意）
最初はpythonで音の制御をしようとしており，以下のサイトを参考にして，音声信号処理の練習をしていた．
http://aidiary.hatenablog.com/entry/20110514/1305377659



### 独自開発技術（Hack Dayで開発したもの）
#### 2日間に開発した独自の機能・技術
* Unityでセンサ情報を獲得
* センサ情報をもとに音のフィルタ周波数を変更
* 加速度をもとにしたパフォーマンスのアルゴリズムを作成
* パフォーマンスのアルゴリズムをC＃で実装


