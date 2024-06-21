# Game Design Document
## Game Overview
| Title      | Platform         | Genre                   | Rating | Target                | Release date | Publisher |
| ---------- | ---------------- | ----------------------- | ------ | --------------------- | ------------ | --------- |
| Close Call | Windows, Android | CQB 2D top-down shooter | 16+    | 2D shooter game lover | TBA          | Apip      |

Mini CQB adalah game tembak-menembak dua dimensi gaya top-down dengan menekankan pertempuran jarak ruang dekat (Close-quarter combat) serta unsur taktisnya. Pemain mengendalikan satu orang tokoh polisi atau tentara yang "juga bisa ditemani oleh bot teman lain". Pemain mengalahkan musuh dengan cara menghabisi musuh dengan senjata api, kemudian dibantu dengan alat taktis lain seperti granat denyar (flashbang), granat, bom asap, peledak temple, dan sebagainya. Pemain harus mengalahkan semua musuh dalam suatu level untuk menang (atau syarat lain sesuai misi).

## High Concept
Close Call memosisikan player sebagai seorang personel penyerbu untuk melumpuhkan superioritas musuh dalam ruang sempit dan tertutup, memaksa player untuk mengukur dan merencanakan setiap aksi yang hendak diambil demi mencapai misi. Alat-alat taktis seperti granat, bom asap, pistol cermin, dan lainnya tersedia untuk player. 

## Unique Selling Points
Apa ya

## Platform Minimum Requirements
Iso urip.

## Competence Title
Close Call

## Player Vision
Player melihat apa yang karakter player dapat lihat. Jika suatu area belum tereksplor, area tersebut akan berwarna hitam (atau warna lain) untuk menutupi semua informasi letak musuh, letak perabotan, atau pintu. Jika suatu area telah terekspos oleh FOV player, area tersebut akan berwarna abu-abu dengan alpha, serta menampakkan letak-letak map kecuali musuh.

![contoh](https://youtu.be/CSeUMTaNFYk?si=wih6S6mgZAP0_n36)

## Gameplay
### Movement
Player dapat berjalan dan mengendap.
#### Berjalan
Player berjalan dengan kecepatan sedang. Ini adalah kondisi normal movement player.

#### Mengendap
Player berjalan dengan mengendap untuk memperlahan langkah ketika bermanuver  ke dalam ruangan. 
![Ready or Not](https://youtu.be/5W0mTk-g8uE?si=IP7G8o3uweJurM8f)


### Offense
#### Shooting
##### Bullet Spread
Ketika menembak, player akan mengalami persebaran peluru. Semakin tinggi frekuensi tembakan, maka persebaran peluru akan semakin besar.

##### Targeting
Player mengarahkan secara umum cursor ke sprite musuh. Jika cursor tepat di atas sprite musuh, ini berarti akurasi = 100% dan ada chance critical damage atau headshot. Jika cursor lebih jauh atau lebih dekat dari sprite musuh relatif terhadap player, ini berarti akurasi = <100%. 

Skenario Targeting hanya terjadi jika peluru mengenai sprite musuh.

